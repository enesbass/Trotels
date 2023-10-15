using AutoMapper;
using Trotels.BL.Concrete;
using Trotels.Entity.Authentication;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Areas.AdminArea.Models.DTOs;
using Trotels.WebMVC.Areas.UserArea.Models.DTOs;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.AutoMapperProfile
{
    public class UserProfile:Profile
    {
        public UserProfile() 
        {
           
            CreateMap<BookingCreateDTO, Booking>();
        }
        
    }
}
