using MediatR;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed record GetCurrentLocationListQuery() : IRequest<GetCurrentLocationListQueryResponse>;
}
