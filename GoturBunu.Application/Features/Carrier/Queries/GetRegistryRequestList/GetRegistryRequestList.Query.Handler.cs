using MediatR;
using GoturBunu.Application.Services.Data;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed class GetRegistryRequestListQueryHandler : IRequestHandler<GetRegistryRequestListQuery, GetRegistryRequestListQueryResponse>
    {
        private readonly ICarrierRegistryRequestRepository _carrierRegistryRequestRepository;

        public GetRegistryRequestListQueryHandler(ICarrierRegistryRequestRepository carrierRegistryRequestRepository)
        {
            _carrierRegistryRequestRepository = carrierRegistryRequestRepository;
        }

        public async Task<GetRegistryRequestListQueryResponse> Handle(GetRegistryRequestListQuery request, CancellationToken cancellationToken)
        {
            var data = await _carrierRegistryRequestRepository.PaginateAsync(
                page: request.Page,
                count: request.Count,
                total: out var total,

                predicate: x => (request.Status == null || x.Status == request.Status) &&
                     (request.DateRangeStart == null || x.CreatedAt.Date >= request.DateRangeStart.Value.Date) &&
                     (request.DateRangeEnd == null || x.CreatedAt.Date <= request.DateRangeEnd.Value.Date),

                asNoTracking: true,

                // includes:
                x => x.District,
                x => x.District.Province
            );

            return new(data)
            {
                Page = request.Page,
                Count = request.Count,
                Total = total
            };
        }
    }
}
