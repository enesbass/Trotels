using System.ComponentModel.DataAnnotations;

namespace Trotels.WebMVC.Models.DTOs
{
    public class GuestCreateDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ad Alani Zorunludur.")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Soyad Alani Zorunludur.")]
        public string LastName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Alani Zorunludur.")]
        public string Email { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Sifre Alani Zorunludur.")]
        public string Password { get; set; }


        [MaxLength(11, ErrorMessage = "TcNo 11 Karakterden fazla Olmamalidir")]
        [MinLength(11, ErrorMessage = "TcNo 11 Karakterden az Olmamalidir")]
        public string TcNo { get; set; }
    }
}
