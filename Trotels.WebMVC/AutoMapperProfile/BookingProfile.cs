using AutoMapper;
using Trotels.BL.Concrete;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.AutoMapperProfile
{
    public class BookingProfile:Profile
    {
        public BookingProfile() 
        {
            CreateMap<BookingCreateDTO, Booking>();
        }
        
    }
}
