using GoturBunu.Application.Services.Offer;
using MediatR;

namespace GoturBunu.Application.Features.Offer
{
    public sealed class SendOfferToCommandHandler : IRequestHandler<SendOfferToCommand, SendOfferToCommandResponse>
    {
        private readonly ICarrierOfferService _carrierOfferService;
        public SendOfferToCommandHandler(ICarrierOfferService carrierOfferService)
        {
            _carrierOfferService = carrierOfferService;
        }

        public async Task<SendOfferToCommandResponse> Handle(SendOfferToCommand request, CancellationToken cancellationToken)
        {
            await _carrierOfferService.SendTo(request.CarrierId, request.Offer);
            return new();
        }
    }
}
