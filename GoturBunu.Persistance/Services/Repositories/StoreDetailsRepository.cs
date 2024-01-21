using GoturBunu.Application.Services.Data;
using GoturBunu.Domain.Entities.Store;
using GoturBunu.Persistance.Context;

namespace GoturBunu.Persistance.Services
{
    public class StoreDetailsRepository : BaseEntityRepository<StoreDetails, string, GoturBunuContext>, IStoreDetailsRepository
    {
        public StoreDetailsRepository(GoturBunuContext context) : base(context)
        { }
    }
}
