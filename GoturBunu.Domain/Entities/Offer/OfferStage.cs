using GoturBunu.Domain.Core;

namespace GoturBunu.Domain.Entities.Offer
{
    public class OfferStage : BaseEntity<string>
    {
        public string OfferId { get; set; }
        public Offer Offer { get; set; }

        public EOfferStageStatus Status { get; set; }

        public IList<CarrierOffer> CarrierOffers { get; set; }
    }
}
