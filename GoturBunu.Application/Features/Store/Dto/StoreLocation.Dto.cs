using GoturBunu.Application.Core.CQRS;

namespace GoturBunu.Application.Features.Store
{
    public class StoreLocationDto : LocationDto
    {
        public string StoreId { get; set; }
    }
}
