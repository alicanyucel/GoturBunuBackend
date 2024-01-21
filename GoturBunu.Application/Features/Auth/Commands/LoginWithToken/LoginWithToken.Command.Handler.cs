using MediatR;
using GoturBunu.Application.Services;

namespace GoturBunu.Application.Features.Auth
{
    public sealed class LoginWithTokenCommandHandler : IRequestHandler<LoginWithTokenCommand, LoginWithTokenCommandResponse>
    {
        private readonly IAuthService _authService;
        public LoginWithTokenCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginWithTokenCommandResponse> Handle(LoginWithTokenCommand request, CancellationToken cancellationToken)
        {
            var result = await _authService.LoginWithToken();
            return new(
                AccessToken: result.Token,
                User: result.User,
                Roles: result.Roles,
                Permissions: result.Permissions
            );
        }
    }
}
