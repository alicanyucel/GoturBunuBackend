using GoturBunu.Domain.Entities;
using MediatR;

namespace GoturBunu.Application.Features.Offer
{
    public sealed record class OnOfferResponseCommand(string OfferId, ECarrierOfferResponse Response) : IRequest<OnOfferResponseCommandResponse>;
}
