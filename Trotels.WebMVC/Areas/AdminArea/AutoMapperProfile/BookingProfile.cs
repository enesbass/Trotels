using AutoMapper;
using Trotels.BL.Concrete;
using Trotels.Entity.Authentication;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Areas.AdminArea.Models.DTOs;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.AutoMapperProfile
{
    public class AdminProfile:Profile
    {
        public AdminProfile() 
        {
           
            CreateMap<HotelCreateDTO, Hotel>();
        }
        
    }
}
