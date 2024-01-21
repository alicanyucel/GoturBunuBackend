using GoturBunu.Application.Core.CQRS;

namespace GoturBunu.Application.Features.Store
{
    public sealed record GetRegistryRequestListQueryResponse(List<Domain.Entities.Store.StoreRegistryRequest> Data) : IPaginateResponse;
}