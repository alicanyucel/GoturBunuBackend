using GoturBunu.Application.Security;
using GoturBunu.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoturBunu.Persistance.Context.DataSeed
{
    public class UserData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(BuiltInUsers.Admin);
            builder.HasData(BuiltInUsers.Store);

            builder.HasData(BuiltInUsers.Carrier);
            builder.HasData(BuiltInUsers.Carrier_1);
            builder.HasData(BuiltInUsers.Carrier_2);
            builder.HasData(BuiltInUsers.Carrier_3);
            builder.HasData(BuiltInUsers.Carrier_4);
            builder.HasData(BuiltInUsers.Carrier_5);
            builder.HasData(BuiltInUsers.Carrier_6);
            builder.HasData(BuiltInUsers.Carrier_7);
            builder.HasData(BuiltInUsers.Carrier_8);
            builder.HasData(BuiltInUsers.Carrier_9);
            builder.HasData(BuiltInUsers.Carrier_10);
        }
    }
}
