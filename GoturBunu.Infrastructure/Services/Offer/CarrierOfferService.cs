using GoturBunu.Application.Features.Offer;
using GoturBunu.Application.Services.Offer;
using GoturBunu.Domain.Entities.Identity;
using GoturBunu.Presentation.Hubs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace GoturBunu.Infrastructure.Services.Offer
{
    public class CarrierOfferService : ICarrierOfferService
    {
        private readonly IHubContext<CarrierHub> _hubContext;
        private readonly UserManager<User> _userManager;

        public CarrierOfferService(IHubContext<CarrierHub> hubContext, UserManager<User> userManager)
        {
            _hubContext = hubContext;
            _userManager = userManager;
        }

        public async Task SendTo(string carrierId, CarrierOfferDto offer)
        {
            var carrier = await _userManager.FindByIdAsync(carrierId);
            if (carrier == null || string.IsNullOrEmpty(carrier.HubId)) { return; }

            await _hubContext.Clients.Client(carrier.HubId).SendAsync("OnOffer", offer);
        }
    }
}
