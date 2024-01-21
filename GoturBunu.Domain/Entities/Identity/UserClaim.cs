using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoturBunu.Domain.Entities.Identity
{
    public class UserClaim : IdentityUserClaim<string>
    {
        public virtual string Id { get; set; }
    }

    public class UserClaimConfiguration : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            builder.ToTable("UserClaims").HasKey(x => x.Id);
        }
    }
}
