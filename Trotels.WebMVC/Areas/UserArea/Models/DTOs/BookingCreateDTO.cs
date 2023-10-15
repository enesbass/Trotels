using System.ComponentModel.DataAnnotations;
using AutoMapper;

namespace Trotels.WebMVC.Areas.UserArea.Models.DTOs
{
    public class BookingCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Check in alanini secmeniz zorunludur.")]
        public TimeSpan CheckIn { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Check out alanini secmeniz zorunludur.")]
        public TimeSpan CheckOut { get; set; }

    }
}
