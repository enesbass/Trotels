using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trotels.BL.Abstract;
using Trotels.DAL.Context;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.Areas.UserArea.Controllers
{
    [Area("UserArea")]
	//[Authorize(Roles = "User")]
	public class BookingController : Controller
    {
        private readonly IBookingManager bookingManager;
        private readonly IMapper mapper;
        SqlDbContext db = new SqlDbContext();
        public BookingController(IBookingManager bookingManager, IMapper mapper)
        {
            this.bookingManager = bookingManager;
            this.mapper = mapper;
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
        [HttpPost]

        [ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry<Booking>(Booking bookings) = EntityState.Modified;
        //        db.SaveChanges();
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
            var booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
