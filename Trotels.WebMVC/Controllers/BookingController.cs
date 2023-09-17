using Microsoft.AspNetCore.Mvc;
using Trotels.DAL.Context;

namespace Trotels.WebMVC.Controllers
{
    public class BookingController : Controller
    {
        private readonly SqlDbContext _context;

        public BookingController(SqlDbContext context)
        {
            _context = context;
        }

        // GET : Booking
        //public async Task<IActionResult> Index()
        //{
        //    return _context.Bookings != null ? 
        //        View(await _context.Bookings.ToListAsync()) : 
        //        Problem("Entity set 'SqlDbContext.Bookings' is null.");
            
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
