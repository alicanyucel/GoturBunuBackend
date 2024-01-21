using GoturBunu.Application.Services.Data;
using MediatR;

namespace GoturBunu.Application.Features.Store
{
    public sealed class GetLocationListQueryHandler : IRequestHandler<GetLocationListQuery, GetLocationListQueryResponse>
    {
        private readonly IStoreDetailsRepository _storeDetailsRepository;

        public GetLocationListQueryHandler(IStoreDetailsRepository storeDetailsRepository)
        {
            _storeDetailsRepository = storeDetailsRepository;
        }

        public async Task<GetLocationListQueryResponse> Handle(GetLocationListQuery request, CancellationToken cancellationToken)
        {
            var data = await _storeDetailsRepository.GetListAsync(sd => new StoreLocationDto
            {
                StoreId = sd.StoreId,
                Latitude = sd.Location.X,
                Longitude = sd.Location.Y,
            });
            return new(data);
        }
    }
}
