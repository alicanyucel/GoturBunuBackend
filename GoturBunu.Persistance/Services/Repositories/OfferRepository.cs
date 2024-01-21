using GoturBunu.Application.Services.Data;
using GoturBunu.Domain.Entities.Offer;
using GoturBunu.Persistance.Context;

namespace GoturBunu.Persistance.Services
{
    public class OfferRepository : BaseEntityRepository<Offer, string, GoturBunuContext>, IOfferRepository
    {
        public OfferRepository(GoturBunuContext context) : base(context)
        { }
    }
}
