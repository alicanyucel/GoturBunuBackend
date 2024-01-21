using GoturBunu.Application.Features.Carrier;
using GoturBunu.Application.Security;
using GoturBunu.Application.Services;
using Microsoft.AspNetCore.Http;
using System.Collections.Concurrent;

namespace GoturBunu.Infrastructure.Services
{
    public class CarrierLocationService : ICarrierLocationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ConcurrentDictionary<string, CarrierLocationDto> _locations = new ConcurrentDictionary<string, CarrierLocationDto>();

        public CarrierLocationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Task SetCurrentAsync(double latitude, double longitude)
        {

            var userId = GetUserId();
            var dateTime = DateTime.UtcNow;
            var location = new CarrierLocationDto
            {
                CarrierId = userId,
                Latitude = latitude,
                Longitude = longitude,
                DateTime = DateTime.UtcNow
            };

            _locations.AddOrUpdate(userId, location, (k, v) => location);

            return Task.CompletedTask;
        }

        public Task<List<CarrierLocationDto>> GetCurrentLocationListAsync()
        {
            var list = _locations.Values.ToList();
            return Task.FromResult(list);
        }

        private string GetUserId()
        {
            if (_httpContextAccessor.HttpContext == null)
            {
                throw new InvalidOperationException("User Id not found!");
            }

            var userIdClaim = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Id);
            if (userIdClaim == null)
            {
                throw new InvalidOperationException("User Id not found!");
            }

            return userIdClaim.Value;
        }
    }
}
