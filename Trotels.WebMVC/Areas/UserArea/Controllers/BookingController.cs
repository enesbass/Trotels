using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trotels.BL.Abstract;
using Trotels.DAL.Context;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Areas.UserArea.Models.DTOs;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.Areas.UserArea.Controllers
{
    [Area("UserArea")]
	//[Authorize(Roles = "User")]
	public class BookingController : Controller
    {
        private readonly IBookingManager bookingManager;
        private readonly IMapper mapper;
        private readonly SqlDbContext dbContext;

        public BookingController(IBookingManager bookingManager, IMapper mapper, SqlDbContext dbContext)
        {
            this.bookingManager = bookingManager;
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        // Rezervasyon listesini görüntüleme
        public async Task<IActionResult> Index()
        {
            var bookings = await bookingManager.GetAllAsync();
            return View(bookings);
        }

        //Yeni bir rezervasyon eklemek için formu görüntüleme
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create(int id)
        {
            var booking = await bookingManager.GetByIdAsync(id);
            return View(booking);
        }


        // Rezervasyon detaylarını görüntüleme
        public ActionResult Details(int id)
        {
            return View();
        }

        // Rezervasyon düzenleme formunu görüntüleme
        public ActionResult Edit(int id)
        {
            return View();
        }

        // Rezervasyon düzenleme (HTTP POST)
        //[HttpPost]

        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dbContext.Entry<Booking>(Booking booking) = EntityState.Modified;
        //        dbContext.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        // Rezervasyon silme
        public ActionResult Delete(int id)
        {
            return View();
        }

        //// Rezervasyon silme (HTTP POST)
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var booking = dbContext.Bookings.Find(id);
            dbContext.Bookings.Remove(booking);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Booking/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,CheckIn,ChechOut")] Trotels.Entity.Concrete.Booking booking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        dbContext.Add(dbContext);
        //        await dbContext.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(dbContext);
        //}

        // POST: Booking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(BookingCreateDTO CreateDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(CreateDTO);
            }

            var booking = mapper.Map<Trotels.Entity.Concrete.Booking>(CreateDTO);
            await bookingManager.InsertAsync(booking);
            return RedirectToAction(nameof(Index));
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
