using GoturBunu.Application.Core.CQRS;

namespace GoturBunu.Application.Features.Offer
{
    public class CarrierOfferDto
    {
        public string OfferId { get; set; }

        public string StoreName { get; set; }

        public LocationDto PacketLocation { get; set; }
        public LocationDto StoreLocation { get; set; }

        public string Description { get; set; }
    }
}
