using MediatR;
using GoturBunu.Application.Services;
using Microsoft.AspNetCore.Authorization;

namespace GoturBunu.Application.Features.Auth
{
    public sealed class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutCommandResponse>
    {
        private readonly IAuthService _authService;
        public LogoutCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        [Authorize]
        public async Task<LogoutCommandResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            await _authService.Logout();
            return new();
        }
    }
}
