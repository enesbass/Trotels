using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Trotels.WebMVC.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var roller = roleManager.Roles.ToList();
            return View(roller);
        }
        public async Task<IActionResult> Create()
        {
            IdentityRole role = new();
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (!ModelState.IsValid)
            {
                return View(role);
            }

            var result = await roleManager.CreateAsync(role);
            if (!result.Succeeded)
            {
                return View(role);
            }
            return RedirectToAction("Index");
        }
    }
}
