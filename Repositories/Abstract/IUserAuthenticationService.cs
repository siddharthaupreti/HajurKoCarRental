using Hajur_Ko_Car_Rental.Models.DTO;

namespace Hajur_Ko_Car_Rental.Repositories.Abstract
{
	public interface IUserAuthenticationService
	{
		Task<Status> LoginAsync(LoginModel model);
		Task LogoutAsync();
		Task<Status> RegisterAsync(RegistrationModel model);
	}
}
