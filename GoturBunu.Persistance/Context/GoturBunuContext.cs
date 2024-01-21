using GoturBunu.Domain.Core;
using GoturBunu.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using GoturBunu.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GoturBunu.Domain.Entities.Store;
using GoturBunu.Domain.Entities.Carrier;
using GoturBunu.Domain.Entities.Offer;

namespace GoturBunu.Persistance.Context
{
    public class GoturBunuContext : IdentityDbContext<User, Role, string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<StoreRegistryRequest> StoreRegistryRequests { get; set; }
        public DbSet<CarrierRegistryRequest> CarrierRegistryRequests { get; set; }

        public DbSet<StoreDetails> StoreDetails { get; set; }

        public DbSet<Packet> Packets { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferStage> OfferStages { get; set; }
        public DbSet<CarrierOffer> CarrierOffers { get; set; }

        public DbSet<Test> Tests { get; set; }

        public GoturBunuContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(Domain.AssemblyReference).Assembly);
            builder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is ITraceableEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Modified)
                {
                    ((ITraceableEntity)entityEntry.Entity).ModifiedAt = DateTime.Now;
                }

                if (entityEntry.State == EntityState.Added)
                {
                    ((ITraceableEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
