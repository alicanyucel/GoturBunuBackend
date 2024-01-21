using GoturBunu.Domain.Core;
using GoturBunu.Domain.Entities.Identity;

namespace GoturBunu.Domain.Entities.Offer
{
    public class CarrierOffer : BaseEntity<string>
    {
        public string CarrierId { get; set; }
        public User Carrier { get; set; }

        public ECarrierOfferResponse Response { get; set; }
    }
}
