using Microsoft.AspNetCore.Mvc;

namespace Trotels.WebMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
