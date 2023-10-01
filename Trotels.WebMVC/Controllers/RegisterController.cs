using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Trotels.DAL.Context;
using Trotels.Entity.Authentication;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.Controllers
{
	public class RegisterController : Controller
	{
		private readonly SqlDbContext dbContext;
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;
		private readonly IMapper mapper;

		public RegisterController(SqlDbContext dbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
		{
			this.dbContext = dbContext;
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;
			this.mapper = mapper;
		}
		[HttpGet]
		public IActionResult Index()
		{
			RegisterDTO registerDTO = new RegisterDTO();
			return View(registerDTO);
		}
		[HttpPost]
		//public async Task<IActionResult> Register(RegisterDTO registerDTO)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		ModelState.AddModelError("", "Yanlis sifre veya Email");
		//		return View(registerDTO);
		//	}

		//	AppUser? user = await userManager.FindByEmailAsync(registerDTO.Email);

		//	bool IsAdmin = false;
		//	bool IsUser = false;


		//	//if (user != null)
		//	//{
		//	//    signInManager.PasswordSignInAsync(user, loginDTO.Password, true, true);
		//	//    return RedirectToAction("Index", "Home");
		//	//}
		//	var result = await signInManager.PasswordSignInAsync(user, registerDTO.Password, true, true);

		//	if (result.Succeeded)
		//	{
		//		if (IsAdmin)
		//		{
		//			return RedirectToAction("Index", "Home", new { Area = "AdminArea" });
		//		}
		//		else if (IsUser)
		//		{
		//			return RedirectToAction("Index", "Home", new { Area = "UserArea" });
		//		}
		//	}

		//	return View(registerDTO);
		//}
		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
		[HttpGet]
		public async Task<IActionResult> Register()
		{
			LoginDTO registerDTO = new LoginDTO();
			return View(registerDTO);

		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterDTO registerDTO)
		{
			AppUser user = mapper.Map<AppUser>(registerDTO);
			var result = await userManager.CreateAsync(user, registerDTO.Password);
			if (result.Succeeded)
			{
				var role = new IdentityRole();
				role.Name = "User";
				await roleManager.CreateAsync(role);
				await userManager.AddToRoleAsync(user, role.Name);
				await dbContext.SaveChangesAsync();
				return RedirectToAction("Index", "Login", new { Area = "UserArea" });

				RedirectToAction("Index", "Home");

			}
			ModelState.AddModelError("", "Kayıt Başarısız");
			return View(registerDTO);

			//if (ModelState.IsValid)
			//{

			//	dbContext.Add(registerDTO);
			//	await dbContext.SaveChangesAsync();
			//	return RedirectToAction(nameof(Index));
			//}
			//return View(registerDTO);
		}
	}
}
