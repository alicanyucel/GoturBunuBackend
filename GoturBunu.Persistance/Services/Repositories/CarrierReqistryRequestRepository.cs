using GoturBunu.Application.Services.Data;
using GoturBunu.Domain.Entities.Carrier;
using GoturBunu.Persistance.Context;

namespace GoturBunu.Persistance.Services
{
    public class CarrierReqistryRequestRepository : BaseEntityRepository<CarrierRegistryRequest, string, GoturBunuContext>, ICarrierRegistryRequestRepository
    {
        public CarrierReqistryRequestRepository(GoturBunuContext context) : base(context)
        { }
    }
    
}
