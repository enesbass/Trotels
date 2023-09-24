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

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
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
                return View(loginDTO);
            }

            AppUser? user = await userManager.FindByEmailAsync(loginDTO.Email);

            if (user != null)
            {
                signInManager.PasswordSignInAsync(user, loginDTO.Password, true, true);
                return RedirectToAction("Index", "Home");
            }

            return View(loginDTO);
        }
    }
}
