using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trotels.BL.Concrete;
using Trotels.DAL.Context;
using Trotels.Entity.Authentication;
using Trotels.Entity.Concrete;

namespace Trotels.WebMVC.Controllers
{
    public class HotelController : Controller
    {
		private readonly SqlDbContext dbContext;
		private readonly HotelManager _hotelManager;
		private readonly IMapper mapper;

		public HotelController(SqlDbContext dbContext, 
									HotelManager _hotelManager, 
									IMapper mapper)
        {
            this.dbContext = dbContext;
			this._hotelManager = _hotelManager;
			this.mapper = mapper;

        }
		//[HttpPost]
		//public IActionResult Index(Hotel hotel)
		//{
		//    hotelManager.Add(hotel);
		//    hotelManager.SaveChanges();
		//    return RedirectToAction(nameof(Index));

		//}

		[HttpGet]
		// GET: Hotel/Index
		public async Task<IActionResult> Index()
		{
			var hotels = await dbContext.Hotels.ToListAsync();
			return View(hotels);
		}

		[HttpGet]
		// GET: Hotel/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var hotel = await dbContext.Hotels.FirstOrDefaultAsync(m => m.Id == id);
			if (hotel == null)
			{
				return NotFound();
			}

			return View(hotel);
		}

		[HttpPost]
		// GET: Hotel/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Hotel/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Hotel hotel)
		{
			if (ModelState.IsValid)
			{
				dbContext.Add(hotel);
				await dbContext.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(hotel);
		}

		// GET: Hotel/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var hotel = await dbContext.Hotels.FindAsync(id);
			if (hotel == null)
			{
				return NotFound();
			}
			return View(hotel);
		}

		// POST: Hotel/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Address,PricePerNight")] Hotel hotel)
		{
			if (id != hotel.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					dbContext.Update(hotel);
					await dbContext.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!HotelExists(hotel.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(hotel);
		}

		// GET: Hotel/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var hotel = await dbContext.Hotels.FirstOrDefaultAsync(m => m.Id == id);
			if (hotel == null)
			{
				return NotFound();
			}

			return View(hotel);
		}

		// POST: Hotel/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var hotel = await dbContext.Hotels.FindAsync(id);
			dbContext.Hotels.Remove(hotel);
			await dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool HotelExists(int id)
		{
			return dbContext.Hotels.Any(e => e.Id == id);
		}
	}
}
