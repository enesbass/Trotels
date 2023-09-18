using AutoMapper;
using Trotels.Entity.Concrete;
using Trotels.WebMVC.Models.DTOs;

namespace Trotels.WebMVC.AutoMapperProfile
{
    public class GuestProfile:Profile
    {
        public GuestProfile()
        {
            CreateMap<GuestCreateDTO, Guest>();
            //CreateMap<GuestDeleteDTO, Guest>();
        }
    }
}
