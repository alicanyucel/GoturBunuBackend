using GoturBunu.Domain.Entities;
using GoturBunu.Application.Core.CQRS;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed record GetRegistryRequestListQuery(
        ERegisteryRequestStatus? Status,
        DateTime? DateRangeStart,
        DateTime? DateRangeEnd
    ) : IPaginateRequest<GetRegistryRequestListQueryResponse>;
}
