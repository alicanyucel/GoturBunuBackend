using GoturBunu.Application.Security;
using GoturBunu.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoturBunu.Persistance.Context.DataSeed
{
    public class UserRoleData : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(BuiltInUserRoles.Admin);
            builder.HasData(BuiltInUserRoles.Store);

            builder.HasData(BuiltInUserRoles.Carrier);
            builder.HasData(BuiltInUserRoles.Carrier_1);
            builder.HasData(BuiltInUserRoles.Carrier_2);
            builder.HasData(BuiltInUserRoles.Carrier_3);
            builder.HasData(BuiltInUserRoles.Carrier_4);
            builder.HasData(BuiltInUserRoles.Carrier_5);
            builder.HasData(BuiltInUserRoles.Carrier_6);
            builder.HasData(BuiltInUserRoles.Carrier_7);
            builder.HasData(BuiltInUserRoles.Carrier_8);
            builder.HasData(BuiltInUserRoles.Carrier_9);
            builder.HasData(BuiltInUserRoles.Carrier_10);
        }
    }
}
