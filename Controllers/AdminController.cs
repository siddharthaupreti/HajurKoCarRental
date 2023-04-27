using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hajur_Ko_Car_Rental.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
