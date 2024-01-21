using GoturBunu.Application.Services.Offer;
using GoturBunu.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace GoturBunu.Application.Features.Offer
{
    public sealed class SetCarrierHubIdCommandHandler : IRequestHandler<SetCarrierHubIdCommand, SetCarrierHubIdCommandResponse>
    {
        private readonly UserManager<User> _userManager;
        public SetCarrierHubIdCommandHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<SetCarrierHubIdCommandResponse> Handle(SetCarrierHubIdCommand request, CancellationToken cancellationToken)
        {
            var carrier = await _userManager.FindByIdAsync(request.CarrierId);

            carrier.HubId = request.HubId;

            await _userManager.UpdateAsync(carrier);
            return new();
        }
    }
}
