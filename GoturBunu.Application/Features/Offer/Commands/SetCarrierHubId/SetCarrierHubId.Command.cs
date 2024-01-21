using MediatR;

namespace GoturBunu.Application.Features.Offer
{
    public sealed record class SetCarrierHubIdCommand(
         string CarrierId, string? HubId
     ) : IRequest<SetCarrierHubIdCommandResponse>;
}
