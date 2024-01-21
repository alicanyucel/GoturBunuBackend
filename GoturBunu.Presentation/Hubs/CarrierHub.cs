using MediatR;
using GoturBunu.Presentation.Abstraction;
using Microsoft.AspNetCore.Authorization;
using GoturBunu.Application.Features.Offer;
using GoturBunu.Application.Security;
using GoturBunu.Application.Security.Permissions;

namespace GoturBunu.Presentation.Hubs
{
    [Authorize(nameof(CarrierHubConnectionPermission))]
    public class CarrierHub : ApiHub
    {
        public CarrierHub(IMediator mediator) : base(mediator) { }

        [Authorize(nameof(OnOfferResponseCommandPermission))]
        public async Task<OnOfferResponseCommandResponse> OnResponse(OnOfferResponseCommand command) => await _mediator.Send(command);

        public override async Task OnConnectedAsync()
        {
            var userIdClaim = Context.User?.Claims.First(c => c.Type == ClaimTypes.Id);
            if (userIdClaim == null) { return; }

            await _mediator.Send(new SetCarrierHubIdCommand(userIdClaim.Value, Context.ConnectionId));
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var userIdClaim = Context.User?.Claims.First(c => c.Type == ClaimTypes.Id);
            if (userIdClaim == null) { return; }

            await _mediator.Send(new SetCarrierHubIdCommand(userIdClaim.Value, null));
            await base.OnDisconnectedAsync(exception);
        }
    }
}
