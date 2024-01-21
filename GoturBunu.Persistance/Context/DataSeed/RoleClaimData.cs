using GoturBunu.Application.Security;
using GoturBunu.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoturBunu.Persistance.Context.DataSeed
{
    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            var id = 1;


            var permissions = Security.GetAllPermissions();
            builder.HasData(permissions.OrderBy(p => p).Select((permission, idx) =>
            {
                var claim = new RoleClaim()
                {
                    Id = id,
                    ClaimType = ClaimTypes.Permission,
                    ClaimValue = permission,
                    RoleId = BuiltInRoles.Admin.Id
                };

                id++;
                return claim;
            }).ToList());

            var carrierPermissions = Security.GetCarrierPermissions();
            builder.HasData(carrierPermissions.OrderBy(p => p).Select((permission, idx) =>
            {
                var claim = new RoleClaim()
                {
                    Id = id,
                    ClaimType = ClaimTypes.Permission,
                    ClaimValue = permission,
                    RoleId = BuiltInRoles.Carrier.Id
                };

                id++;
                return claim;
            }).ToList());

            var storePermissions = Security.GetStorePermissions();
            builder.HasData(storePermissions.OrderBy(p => p).Select((permission, idx) =>
            {
                var claim = new RoleClaim()
                {
                    Id = id,
                    ClaimType = ClaimTypes.Permission,
                    ClaimValue = permission,
                    RoleId = BuiltInRoles.Store.Id
                };

                id++;
                return claim;
            }).ToList());
        }
    }
}
