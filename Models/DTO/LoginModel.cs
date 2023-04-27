using System.ComponentModel.DataAnnotations;

namespace Hajur_Ko_Car_Rental.Models.DTO
{
	public class LoginModel
	{
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }

	}
}
