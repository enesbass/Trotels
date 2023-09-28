using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trotels.BL.Concrete;
using Trotels.DAL.Context;
using Trotels.Entity.Authentication;
using Trotels.Entity.Concrete;

namespace Trotels.WebMVC.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[Authorize(Roles = "Admin")]
    public class HotelController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly HotelManager hotelManager;

        public HotelController(ILogger<HomeController> _logger, HotelManager _hotelManager)
        {
            _logger = logger;
            _hotelManager = hotelManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(Hotel hotel)
        //{
        //    hotelManager.Add(hotel);
        //    hotelManager.SaveChanges();
        //    return RedirectToAction(nameof(Index));

        //}
    }
}
