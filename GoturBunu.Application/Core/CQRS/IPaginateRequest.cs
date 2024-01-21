using MediatR;

namespace GoturBunu.Application.Core.CQRS
{
    public record IPaginateRequest<TResponse> : IRequest<TResponse>
    {
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
