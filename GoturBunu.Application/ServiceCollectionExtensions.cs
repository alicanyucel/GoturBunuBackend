using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GoturBunu.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            serviceCollection.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            return serviceCollection;
        }

    }
}
