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

            


            var result = await signInManager.PasswordSignInAsync(user, loginDTO.Password,true, true);
            var role = userManager.GetRolesAsync(user).Result.FirstOrDefault();

            if (result.Succeeded)
            {
                if (role == "Admin")
                {
                    return RedirectToAction("Index", "Home", new { Area = "AdminArea" });
                }
                else if(role == "User")
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
           
           
			RegisterDTO registerDTO = new RegisterDTO();
			return View(registerDTO);

		}
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            AppUser user = mapper.Map<AppUser>(registerDTO);
            user.UserName = registerDTO.Email;

            //user.LockoutEnabled = true;
            //user.AccessFailedCount = 5;

            var result = await userManager.CreateAsync(user, registerDTO.Password);
            if (result.Succeeded)
            {
                
                var userRole = await roleManager.FindByNameAsync("User");
                if (userRole == null)
                {
                    userRole = new IdentityRole();
                    userRole.Name = "User";
                    await roleManager.CreateAsync(userRole);
                   
                }
               await userManager.AddToRoleAsync(user, userRole.Name);
                
                
				return RedirectToAction("Index", "Login", new {Area = "UserArea"});

			}
            ModelState.AddModelError("", "Kayıt Başarısız");
            return View(registerDTO);
		}
	}
}
