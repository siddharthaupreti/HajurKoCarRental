using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace Hajur_Ko_Car_Rental.Models.Identity
{
	public class ApplicationUser : IdentityUser
	{
		 public string? FullName { get; set; }
	}
}
