using GoturBunu.Application.Services.Data;
using MediatR;

namespace GoturBunu.Application.Features.Store
{
    public sealed class GetRegistryRequestListQueryHandler : IRequestHandler<GetRegistryRequestListQuery, GetRegistryRequestListQueryResponse>
    {
        private readonly IStoreRegistryRequestRepository _storeRegistryRequestRepository;

        public GetRegistryRequestListQueryHandler(IStoreRegistryRequestRepository storeRegistryRequestRepository)
        {
            _storeRegistryRequestRepository = storeRegistryRequestRepository;
        }

        public async Task<GetRegistryRequestListQueryResponse> Handle(GetRegistryRequestListQuery request, CancellationToken cancellationToken)
        {
            var data = await _storeRegistryRequestRepository.PaginateAsync(
                page: request.Page,
                count: request.Count,
                total: out var total,

                predicate: x => (request.Status == null || x.Status == request.Status) &&
                     (request.DateRangeStart == null || x.CreatedAt.Date >= request.DateRangeStart.Value.Date) &&
                     (request.DateRangeEnd == null || x.CreatedAt.Date <= request.DateRangeEnd.Value.Date),

                asNoTracking: true
            );

            return new(data)
            {
                Page = request.Page,
                Count = request.Count,
                Total = total,
            };
        }
    }
}
