using GoturBunu.Application.Features.Auth;
using GoturBunu.Domain.Entities.Identity;

namespace GoturBunu.Application.Services
{
    public interface IAuthService
    {
        Task<LoginResultDto> Login(string email, string password);
        Task<LoginResultDto> LoginWithToken();
        Task Logout();
        Task<bool> Register(User user, string password);
    }
}
