using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trotels.BL.Abstract;
using Trotels.DAL.Context;

namespace Trotels.WebMVC.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[Authorize(Roles = "Admin")]
    public class BookingController : Controller
    {
        private readonly IBookingManager manager;
        private readonly IHotelManager hotelManager;
        private readonly IRoomManager roomManager;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly SqlDbContext dbContext;

        public BookingController(IBookingManager manager, IHotelManager hotelManager, IRoomManager roomManager, IMapper mapper, IWebHostEnvironment hostEnvironment, SqlDbContext dbContext)
        {
            this.manager = manager;
            this.hotelManager = hotelManager;
            this.roomManager = roomManager;
            this.mapper = mapper;
            this.hostEnvironment = hostEnvironment;
            this.dbContext = dbContext;
        }

        //// GET: Booking
        //public async Task<IActionResult> Index()
        //{
        //    List<TEntity> entities = await _context.Set<TEntity>().ToListAsync();
        //    return View(entities);
        //}

        //// GET: Booking/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    TEntity entity = await _context.Set<TEntity>().FindAsync(id);

        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(entity);
        //}

        // GET: Booking/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: Booking/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Property1,Property2,Property3")] TEntity entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(entity);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(entity);
        //}

        //// GET: Booking/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    TEntity entity = await _context.Set<TEntity>().FindAsync(id);

        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(entity);
        //}

        //// POST: Booking/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Property1,Property2,Property3")] TEntity entity)
        //{
        //    if (id != entity.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(entity);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EntityExists(entity.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(entity);
        //}

        //// GET: Booking/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    TEntity entity = await _context.Set<TEntity>().FindAsync(id);

        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(entity);
        //}

        //// POST: Booking/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    TEntity entity = await _context.Set<TEntity>().FindAsync(id);
        //    _context.Set<TEntity>().Remove(entity);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EntityExists(int id)
        //{
        //    return _context.Set<TEntity>().Any(e => e.Id == id);
        //}
    }
}
