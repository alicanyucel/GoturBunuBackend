using GoturBunu.Domain.Core;
using GoturBunu.Domain.Entities.Identity;
using NetTopologySuite.Geometries;

namespace GoturBunu.Domain.Entities.Offer
{
    public class Packet : BaseEntity<string>
    {
        public string StoreId { get; set; }
        public User Store { get; set; }

        public Point Location { get; set; }
    }
}
