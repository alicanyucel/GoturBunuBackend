using GoturBunu.Application.Core.CQRS;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed record GetRegistryRequestListQueryResponse(List<Domain.Entities.Carrier.CarrierRegistryRequest> Data) : IPaginateResponse;
}
