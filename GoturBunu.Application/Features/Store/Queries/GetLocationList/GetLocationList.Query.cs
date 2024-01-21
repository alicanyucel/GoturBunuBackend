using MediatR;

namespace GoturBunu.Application.Features.Store
{
    public sealed record GetLocationListQuery() : IRequest<GetLocationListQueryResponse>;
}
