using MediatR;
using GoturBunu.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;
using GoturBunu.Application.Features.Auth;
using Microsoft.AspNetCore.Authorization;

namespace GoturBunu.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator) { }

        [HttpPost("[action]")]
        public async Task<LoginCommandResponse> Login(LoginCommand command) => await _mediator.Send(command);


        [Authorize]
        [HttpPost("[action]")]
        public async Task<LoginWithTokenCommandResponse> LoginWithToken(LoginWithTokenCommand command) => await _mediator.Send(command);


        [Authorize]
        [HttpPost("[action]")]
        public async Task<LogoutCommandResponse> Logout(LogoutCommand command) => await _mediator.Send(command);
    }
}

