using Hajur_Ko_Car_Rental.Models.DTO;
using Hajur_Ko_Car_Rental.Models.Identity;
using Hajur_Ko_Car_Rental.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Hajur_Ko_Car_Rental.Controllers
{
	[Authorize]
	public class DashboardController : Controller
	{
        private readonly IUserAuthenticationService _authService;
        private readonly UserManager<ApplicationUser> _userManager;


        public DashboardController(IUserAuthenticationService authService,
            UserManager<ApplicationUser> userManager)
        {
            _authService = authService;
            _userManager = userManager;
        }


        public IActionResult Display()
		{
			return View();
		}
      

        //      public IActionResult Index()
        //{
        //	return View();
        //}


        public IActionResult Registration()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (!ModelState.IsValid) { return View(model); }
            //model.Role = "user";
            var result = await _authService.RegisterAsync(model);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }

        public async Task<IActionResult> ViewAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
    }
}
