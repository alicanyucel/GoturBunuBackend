using GoturBunu.Domain.Core;

namespace GoturBunu.Domain.Entities.Offer
{
    public class Offer : BaseEntity<string>
    {
        public string PacketId { get; set; }
        public Packet Packet { get; set; }

        public IList<OfferStage> Stages { get; set; }
    }
}
