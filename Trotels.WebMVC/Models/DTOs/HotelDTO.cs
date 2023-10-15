using System.ComponentModel.DataAnnotations;

namespace Trotels.WebMVC.Models.DTOs
{
	public class HotelDTO
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Otel İsmi Girmek Zorunludur.")]
		public string HotelName { get; set; }
		
		//---------------------------------------
		[Required(AllowEmptyStrings = false, ErrorMessage = "Otel Adresi Girmek Zorunludur.")]
		public string HotelAddress { get; set; }
		
		//---------------------------------------
		[Required(AllowEmptyStrings = false, ErrorMessage = "Otel Şehri Girmek Zorunludur.")]
		public string HotelCity { get; set; }

		//---------------------------------------
		[Required(AllowEmptyStrings = false, ErrorMessage = "Otel Ülkesi Girmek Zorunludur.")]
		public string HotelCountry { get; set; }
	}
}
