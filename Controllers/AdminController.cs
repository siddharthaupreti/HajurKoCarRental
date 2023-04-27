using Hajur_Ko_Car_Rental.Models.DTO;
using Hajur_Ko_Car_Rental.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hajur_Ko_Car_Rental.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
	{
        private readonly IUserAuthenticationService _authService;
        
  //      public IActionResult Index()
		//{
		//	return View();
		//}

    }
}
