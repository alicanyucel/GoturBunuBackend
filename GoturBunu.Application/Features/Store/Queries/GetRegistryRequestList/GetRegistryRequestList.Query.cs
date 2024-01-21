using GoturBunu.Application.Core.CQRS;
using GoturBunu.Domain.Entities;
using MediatR;


namespace GoturBunu.Application.Features.Store
{
    public sealed record GetRegistryRequestListQuery(
       ERegisteryRequestStatus? Status,
       DateTime? DateRangeStart,
       DateTime? DateRangeEnd
   ) : IPaginateRequest<GetRegistryRequestListQueryResponse>;
}
