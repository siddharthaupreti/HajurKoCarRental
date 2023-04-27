using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hajur_Ko_Car_Rental.Controllers
{
	[Authorize]
	public class DashboardController : Controller
	{
		public IActionResult Display()
		{
			return View();
		}
	}
}
