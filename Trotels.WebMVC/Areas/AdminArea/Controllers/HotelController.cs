using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trotels.BL.Abstract;
using Trotels.BL.Concrete;
using Trotels.DAL.Context;
using Trotels.Entity.Authentication;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Areas.AdminArea.Models.DTOs;

namespace Trotels.WebMVC.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class HotelController : Controller
    {

		private readonly IHotelManager hotelManager;
		private readonly IMapper mapper;
		private readonly SqlDbContext dbContext;

		public HotelController(IHotelManager hotelManager, IMapper mapper, SqlDbContext dbContext)
		{

			this.hotelManager = hotelManager;
			this.mapper = mapper;
			this.dbContext = dbContext;
		}

		// GET: AdminArea/Hotels
		public async Task<IActionResult> Index()
		{
			var hotels = await hotelManager.GetAllAsync();
			return View(hotels);
		}

		// GET: AdminArea/Hotels/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || dbContext.Hotels == null)
			{
				return NotFound();
			}

			var hotel = await dbContext.Hotels
				.FirstOrDefaultAsync(m => m.Id == id);
			if (hotel == null)
			{
				return NotFound();
			}

			return View();
		}

		// GET: AdminArea/Hotels/Create
		public IActionResult Create()
		{
			HotelCreateDTO createDTO = new HotelCreateDTO();
			return View(createDTO);
		}

		// POST: AdminArea/Hotels/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(HotelCreateDTO createDTO)
		{
			if (!ModelState.IsValid)
			{
				return View(createDTO);
			}
			var hotel = mapper.Map<Trotels.Entity.Concrete.Hotel>(createDTO);
			await hotelManager.InsertAsync(hotel);

			return RedirectToAction(nameof(Index));

		}

		// GET: AdminArea/Hotels/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || dbContext.Hotels == null)
			{
				return NotFound();
			}

			var hotel = await dbContext.Hotels.FindAsync(id);
			if (hotel == null)
			{

				return NotFound();
			}
			return View();
		}

		// POST: AdminArea/Hotels/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("HotelName,HotelAddress, HotelCity,HotelCountry")] Trotels.Entity.Concrete.Hotel hotel)
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

		// GET: AdminArea/Hotels/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || dbContext.Hotels == null)
			{
				return NotFound();
			}

			var hotel = await dbContext.Hotels
				.FirstOrDefaultAsync(m => m.Id == id);
			if (hotel == null)
			{
				return NotFound();
			}

			return View(hotel);
		}

		// POST: AdminArea/Hotels/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (dbContext.Hotels == null)
			{
				return Problem("Entity set 'SqlDbContext.Hotels'  is null.");
			}
			var hotel = await dbContext.Hotels.FindAsync(id);
			if (hotel != null)
			{
				dbContext.Hotels.Remove(hotel);
			}

			await dbContext.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool HotelExists(int id)
		{
			return (dbContext.Hotels?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
