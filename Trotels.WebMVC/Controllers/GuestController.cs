using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Trotels.BL.Abstract;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.Controllers
{
    public class GuestController : Controller
    {
        private readonly IGuestManager guestManager;
        private readonly IMapper mapper;

        public GuestController(IGuestManager guestManager, IMapper mapper)
        {
            this.guestManager = guestManager;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var guests = await guestManager.GetAllAsync();
            return View(guests);
        }

        [HttpGet]
        public IActionResult Create()
        {
            GuestCreateDTO createDTO = new GuestCreateDTO();
            return View(createDTO);
        }

        [HttpPost]

        public async Task<IActionResult> Create(GuestCreateDTO createDTO)
        {
            if (ModelState.IsValid)
            {
                return View(createDTO);
            }
            var guest = mapper.Map<Guest>(createDTO);
            guestManager.InsertAsync(guest);

            return View(createDTO);
        }


    }
}
