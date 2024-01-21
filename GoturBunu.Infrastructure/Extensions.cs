using GoturBunu.Application.Core;
using GoturBunu.Application.Security;
using GoturBunu.Application.Services;
using GoturBunu.Application.Services.Offer;
using GoturBunu.Domain.Entities.Identity;
using GoturBunu.Infrastructure.Middlewares;
using GoturBunu.Infrastructure.Services;
using GoturBunu.Infrastructure.Services.Offer;
using GoturBunu.Persistance.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GoturBunu.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            // IDENTITY
            serviceCollection.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<GoturBunuContext>()
                .AddDefaultTokenProviders();

            serviceCollection.Configure<IdentityOptions>(options =>
            {
                // Default User settings.
                options.User.AllowedUserNameCharacters =
                        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;

                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });
            serviceCollection.Configure<PasswordHasherOptions>(options =>
            {
                options.IterationCount = 12000;
            });

            // JWT
            serviceCollection.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Secret"])),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true
                };

                options.Events = new JwtBearerEvents()
                {
                    OnMessageReceived = context =>
                    {
                        if (!context.Request.Path.HasValue) return Task.CompletedTask;
                        if (!context.Request.Path.Value.StartsWith($"/{Constants.HubsBasePath}/")) return Task.CompletedTask;
                        if (string.IsNullOrEmpty(context.Request.Query[Constants.AccessTokenQueryStringName])) return Task.CompletedTask;

                        context.Token = context.Request.Query[Constants.AccessTokenQueryStringName];
                        return Task.CompletedTask;
                    },
                };
            });

            // AUTHORIZATION
            serviceCollection.AddAuthorization(options =>
            {
                var permissions = Security.GetAllPermissions();
                foreach (var p in permissions)
                {
                    options.AddPolicy(p, policy => policy.RequireClaim(ClaimTypes.Permission, p));
                }
            });


            // CACHING
            serviceCollection.AddMemoryCache();

            // SERVICES
            serviceCollection.AddScoped<IAuthService, AuthService>();
            serviceCollection.AddScoped<IClaimUtils, ClaimUtils>();
            serviceCollection.AddScoped<ICarrierOfferService, CarrierOfferService>();

            serviceCollection.AddSingleton<ICarrierLocationService, CarrierLocationService>();
            serviceCollection.AddSingleton<IJwtUtils, JwtUtils>();

            return serviceCollection;
        }
    }

    public static class WebApplicationExtensions
    {
        public static WebApplication UseInfrastructure(this WebApplication app)
        {
            app.UseAuthentication();
            app.UseMiddleware<ClaimsMiddleware>();
            app.UseAuthorization();
            return app;
        }
    }
}
