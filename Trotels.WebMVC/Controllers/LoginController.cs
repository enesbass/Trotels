using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Trotels.Entity.Authentication;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;
		private readonly IMapper mapper;

		public LoginController(UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager, 
            RoleManager<IdentityRole> roleManager, 
            IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
			this.roleManager = roleManager;
			this.mapper = mapper;
		}
        [HttpGet]
        public IActionResult Index()
        {
            LoginDTO loginDTO = new LoginDTO();
            return View(loginDTO);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Yanlis sifre veya Email");
                return View(loginDTO);
            }

            AppUser? user = await userManager.FindByEmailAsync(loginDTO.Email);

            bool IsAdmin = false;
            bool IsUser = false;


            //if (user != null)
            //{
            //    signInManager.PasswordSignInAsync(user, loginDTO.Password, true, true);
            //    return RedirectToAction("Index", "Home");
            //}
            var result = await signInManager.PasswordSignInAsync(user, loginDTO.Password,true, true);

            if (result.Succeeded)
            {
                if (IsAdmin)
                {
                    return RedirectToAction("Index", "Home", new { Area = "AdminArea" });
                }
                else if(IsUser)
                {
					return RedirectToAction("Index", "Home", new { Area = "UserArea" });
				}
            }

            return View(loginDTO);
        }
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
        public async Task<IActionResult> Register(LoginDTO loginDTO)
        {
            AppUser user = mapper.Map<AppUser>(loginDTO);
            var result = await userManager.CreateAsync(user, loginDTO.Password);
            if (result.Succeeded)
            {
                var role= new IdentityRole();
                role.Name = "User";
                await roleManager.CreateAsync(role);
                await userManager.AddToRoleAsync(user, role.Name);
				return RedirectToAction("Index", "Logn", new {Area = "UserArea"});

			}
            ModelState.AddModelError("", "Kayıt Başarısız");
            return View(loginDTO);
		}
	}
}
