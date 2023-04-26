using System.ComponentModel.DataAnnotations;

namespace Hajur_Ko_Car_Rental.Models.Identity
{
	public class ChangePassword
	{
		[Required(ErrorMessage = "Old Password is required")]
		[DataType(DataType.Password)]
		public string? OldPassword { get; set; }


		[Required(ErrorMessage = "New Password is required")]
		[DataType(DataType.Password)]
		public string? NewPassword { get; set; }


		[Required(ErrorMessage = "Confirm Password is required")]
		[DataType(DataType.Password)]
		[Compare("NewPassword", ErrorMessage = "Passwords do not match")]
		public string? ConfirmPassword { get; set; }
	}
}
