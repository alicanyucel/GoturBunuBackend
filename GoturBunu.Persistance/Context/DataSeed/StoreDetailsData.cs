using GoturBunu.Application.Security;
using GoturBunu.Domain.Entities.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetTopologySuite.Geometries;

namespace GoturBunu.Persistance.Context.DataSeed
{
    public class StoreDetailsData : IEntityTypeConfiguration<StoreDetails>
    {
        public void Configure(EntityTypeBuilder<StoreDetails> builder)
        {
            builder.HasData(new StoreDetails
            {
                Id = "80a20379-193e-4342-944b-8b3f8c929dc9",
                Location = new Point(39.925533, 32.866287) { SRID = 4326 },
                Name = "GOTUR BUNU STORE",
                StoreId = BuiltInUsers.Store.Id
            });
        }
    }
}
