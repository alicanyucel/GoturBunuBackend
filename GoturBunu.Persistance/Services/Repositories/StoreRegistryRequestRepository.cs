using GoturBunu.Application.Services.Data;
using GoturBunu.Domain.Entities.Store;
using GoturBunu.Persistance.Context;

namespace GoturBunu.Persistance.Services
{
    public class StoreRegistryRequestRepository : BaseEntityRepository<StoreRegistryRequest, string, GoturBunuContext>, IStoreRegistryRequestRepository
    {
        public StoreRegistryRequestRepository(GoturBunuContext context) : base(context)
        { }
    }
}
