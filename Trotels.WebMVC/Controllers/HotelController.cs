using Microsoft.AspNetCore.Mvc;

namespace Trotels.WebMVC.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
