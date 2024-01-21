using GoturBunu.Application.Core.CQRS;

namespace GoturBunu.Application.Features.Carrier
{
    public class CarrierLocationDto : LocationDto
    {
        public string CarrierId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
