using Microsoft.AspNetCore.Mvc;

namespace Trotels.WebMVC.Areas.AdminArea
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
