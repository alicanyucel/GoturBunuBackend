using MediatR;

namespace GoturBunu.Application.Features.Offer
{
    public sealed record class SendOfferToCommand(
         string CarrierId,
         CarrierOfferDto Offer
     ) : IRequest<SendOfferToCommandResponse>;
}
