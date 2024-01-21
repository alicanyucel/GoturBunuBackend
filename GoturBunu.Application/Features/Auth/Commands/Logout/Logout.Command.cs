
using MediatR;

namespace GoturBunu.Application.Features.Auth
{
    public sealed record class LogoutCommand() : IRequest<LogoutCommandResponse>;
}
