using GoturBunu.Application.Features.Offer;

namespace GoturBunu.Application.Services.Offer
{
    public interface ICarrierOfferService
    {
        public Task SendTo(string clientCarrierId, CarrierOfferDto offer);
    }
}
