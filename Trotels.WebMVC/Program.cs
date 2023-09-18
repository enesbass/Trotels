using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Trotels.DAL.Context;
using Trotels.WebMVC.AutoMapperProfile;
using AutoMapper;
using Trotels.WebMVC.Extensions;

namespace Trotels.WebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //----------Benim yazdiklarim--------------
            //json dosyasindaki tanimlamayi sqldbcontext nesnesine tanittik.
            builder.Services.AddDbContext<SqlDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("trotels")));
            //----------Benim yazdiklarim--------------

            //builder.Services.AddTrotelsServices();

            // AutoMapper Servislerini ayaga kaldirir
            builder.Services.AddAutoMapper(typeof(GuestProfile));

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
    
            app.UseAuthorization();

            // Kimlik Dogrulama icin gerekli middleware
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}