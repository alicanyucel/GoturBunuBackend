using GoturBunu.Domain.Core;

namespace GoturBunu.Domain.Entities.Carrier
{
    public class CarrierRegistryRequest : BaseEntity<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalIdentityNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ERegisteryRequestStatus Status { get; set; }

        public virtual string DistrictId { get; set; }
        public District District { get; set; }
    }
}
