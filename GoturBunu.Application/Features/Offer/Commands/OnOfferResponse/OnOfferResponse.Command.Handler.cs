using GoturBunu.Application.Services.Offer;
using MediatR;

namespace GoturBunu.Application.Features.Offer
{
    public sealed class OnOfferResponseCommandHandler : IRequestHandler<OnOfferResponseCommand, OnOfferResponseCommandResponse>
    {
        private readonly ICarrierOfferService _carrierOfferService;
        public OnOfferResponseCommandHandler(ICarrierOfferService carrierOfferService)
        {
            _carrierOfferService = carrierOfferService;
        }

        public async Task<OnOfferResponseCommandResponse> Handle(OnOfferResponseCommand request, CancellationToken cancellationToken)
        {
            return new();
        }
    }
}
