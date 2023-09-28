using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Trotels.DAL.Context;
//using Trotels.WebMVC.AutoMapperProfile;
using AutoMapper;
using Trotels.WebMVC.Extensions;
using Microsoft.AspNetCore.Identity;
using Trotels.Entity.Authentication;
using Trotels.WebMVC.AutoMapperProfile;

namespace Trotels.WebMVC
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();


			//json dosyasindaki tanimlamayi sqldbcontext nesnesine tanittik.
			builder.Services.AddDbContext<SqlDbContext>(
				options => options.UseSqlServer(builder.Configuration.GetConnectionString("trotels")));

			//app, serviceleri builder.build dosyas?ndan üste koymam?z gerekiyor
			#region Identity Ayarlari
			builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
			{
				options.Password.RequireDigit = false; // Sayisal bir deger olsunmu
				options.Password.RequireNonAlphanumeric = false; // !*% gibi ifadeler bulunsun mu ?
				options.Password.RequireUppercase = false; // BuyukHarf olsun mu
				options.Password.RequireLowercase = false; // Kucuk Harf olsun mu ?
				options.Password.RequiredLength = 3; // En az kac karakter girmesi gerektigini belirler

				options.User.RequireUniqueEmail = true; // Ayni aynda birden gfazla email olsun mu

				options.SignIn.RequireConfirmedPhoneNumber = false;// Telefon ile dogrulama zorunlumu ?
				options.SignIn.RequireConfirmedEmail = false;
				options.SignIn.RequireConfirmedAccount = false;
			}).AddEntityFrameworkStores<SqlDbContext>();
			#endregion


			builder.Services.AddTrotelsServices();

			#region AutoMapper
			// AutoMapper Servislerini ayaga kaldirir
			builder.Services.AddAutoMapper(typeof(BookingProfile));
			#endregion
			
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}

			// Bu middleware wwwroot klasorunu web'e acar.
			app.UseStaticFiles();

			// Adres cubugundakiu url 'i cozumler
			app.UseRouting();

            #region Identity authentication icin buraya yazilmasi gerekiyor, authorization ustunde olmasi gerekiyor
            app.UseAuthentication();
            #endregion

            app.UseAuthorization();



			#region Area Controller RouteThe service collection cannot be modified because it is read-only
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
				  name: "areas",
				  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
				);
			});
			#endregion

			// Kimlik Dogrulama icin gerekli middleware
			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}