using System.ComponentModel.DataAnnotations;

namespace Trotels.WebMVC.Models.DTOs
{
	public class RegisterDTO
	{
		//[Required(AllowEmptyStrings = false, ErrorMessage = "Ad Zorunlu")]
		//[DataType(DataType.]
		//public string FirstName { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Email Zorunlu")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Sifre Zorunlu")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
