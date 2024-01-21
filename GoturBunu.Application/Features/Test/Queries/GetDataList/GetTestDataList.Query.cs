
using MediatR;

namespace GoturBunu.Application.Features.Test
{
    public sealed record GetTestDataListQuery() : IRequest<GetTestDataListQueryResponse>;
}
