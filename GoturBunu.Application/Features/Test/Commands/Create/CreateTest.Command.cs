
using MediatR;

namespace GoturBunu.Application.Features.Test
{
    public sealed record class CreateTestCommand(int Data, string Name) : IRequest<CreateTestCommandResponse>;
}
