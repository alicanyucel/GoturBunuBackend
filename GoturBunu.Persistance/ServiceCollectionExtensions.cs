using GoturBunu.Application.Services;
using GoturBunu.Application.Services.Data;
using GoturBunu.Persistance.Context;
using GoturBunu.Persistance.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GoturBunu.Persistance
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGoturBunuDbContext(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContextPool<GoturBunuContext>(opt =>
            {
                opt.UseSqlServer(connectionString, x => x.UseNetTopologySuite());
            });

            return serviceCollection;
        }

        public static IServiceCollection AddGoturBunuRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICarrierRegistryRequestRepository, CarrierReqistryRequestRepository>();
            serviceCollection.AddScoped<ITestRepository, TestRepository>();
            serviceCollection.AddScoped<IStoreRegistryRequestRepository, StoreRegistryRequestRepository>();
            serviceCollection.AddScoped<IStoreDetailsRepository, StoreDetailsRepository>();
            serviceCollection.AddScoped<IOfferRepository, OfferRepository>();
            return serviceCollection;
        }

        public static IServiceCollection AddGoturBunuUnitOfWork(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork<GoturBunuContext>>();

            return serviceCollection;
        }
    }
}
