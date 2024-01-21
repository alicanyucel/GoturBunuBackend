using MediatR;
using AutoMapper;
using GoturBunu.Application.Services;

namespace GoturBunu.Application.Features.Auth
{
    public sealed class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IAuthService _authService;
        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var result = await _authService.Login(request.Email, request.Password);
            return new(
                AccessToken: result.Token,
                User: result.User,
                Roles: result.Roles,
                Permissions: result.Permissions
            );
        }
    }
}
