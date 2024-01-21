
using MediatR;

namespace GoturBunu.Application.Features.Auth
{
    public sealed record class LoginCommand(string Email, string Password) : IRequest<LoginCommandResponse>;
}
