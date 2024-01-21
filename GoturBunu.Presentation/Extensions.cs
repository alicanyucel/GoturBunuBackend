using GoturBunu.Application.Core;
using GoturBunu.Presentation.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GoturBunu.Presentation
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPresentation(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddControllers().AddApplicationPart(typeof(AssemblyReference).Assembly);
            serviceCollection.AddSignalR();
            return serviceCollection;
        }
    }

    public static class WebApplicationExtensions
    {
        public static WebApplication UsePresentation(this WebApplication app)
        {
            app.MapControllers();
            app.MapHub<CarrierHub>($"/{Constants.HubsBasePath}/carrier");
            return app;
        }
    }
}
