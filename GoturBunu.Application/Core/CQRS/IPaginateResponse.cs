using MediatR;

namespace GoturBunu.Application.Core.CQRS
{
    public record IPaginateResponse
    {
        public int Page { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
