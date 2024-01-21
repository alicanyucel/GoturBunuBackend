using GoturBunu.Domain.Core;
using GoturBunu.Domain.Entities.Identity;
using NetTopologySuite.Geometries;

namespace GoturBunu.Domain.Entities.Store
{
    public class StoreDetails : BaseEntity<string>
    {
        public string Name { get; set; }
        public Point Location { get; set; }

        public string StoreId { get; set; }
        public User Store { get; set; }
    }
}
