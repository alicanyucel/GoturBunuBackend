using GoturBunu.Application.Features.Carrier;

namespace GoturBunu.Application.Services
{
    public interface ICarrierLocationService
    {
        public Task SetCurrentAsync(double latitude, double longitude);
        public Task<List<CarrierLocationDto>> GetCurrentLocationListAsync();
    }
}
