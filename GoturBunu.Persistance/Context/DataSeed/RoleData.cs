using GoturBunu.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GoturBunu.Application.Security;

namespace GoturBunu.Persistance.Context.DataSeed
{
    public class RoleData : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(BuiltInRoles.Admin, BuiltInRoles.Store, BuiltInRoles.Carrier);
        }
    }
}
