using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hajur_Ko_Car_Rental.Models;
using Hajur_Ko_Car_Rental.Models.Identity;

namespace Hajur_Ko_Car_Rental.Data
{
	public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
