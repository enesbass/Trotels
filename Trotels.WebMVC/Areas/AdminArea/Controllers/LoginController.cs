using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Trotels.Entity.Authentication;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
	//[Authorize(Roles = "Admin")]
	public class LoginController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        
        public LoginController(UserManager<AppUser> userManager,
                            SignInManager<AppUser> signInManager,
                            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
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
            var user = await userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Yanlis sifre veya Email");
                return View(loginDTO);  
            }
            var result = await signInManager.PasswordSignInAsync(user, loginDTO.Password, true, true);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Yanlis sifre veya Email");
            return View(loginDTO);
        }
    }
}
