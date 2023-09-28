using Microsoft.AspNetCore.Mvc;

namespace Trotels.WebMVC.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
