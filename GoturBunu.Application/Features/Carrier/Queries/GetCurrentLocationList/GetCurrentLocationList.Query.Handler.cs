using GoturBunu.Application.Services;
using MediatR;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed class GetCurrentLocationListQueryHandler : IRequestHandler<GetCurrentLocationListQuery, GetCurrentLocationListQueryResponse>
    {
        private readonly ICarrierLocationService _carrierLocationService;

        public GetCurrentLocationListQueryHandler(ICarrierLocationService carrierLocationService)
        {
            _carrierLocationService = carrierLocationService;
        }

        public async Task<GetCurrentLocationListQueryResponse> Handle(GetCurrentLocationListQuery request, CancellationToken cancellationToken)
        {
            var data = await _carrierLocationService.GetCurrentLocationListAsync();
            return new(data);
        }
    }
}
