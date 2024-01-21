using MediatR;
using GoturBunu.Application.Services;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed class SetCurrentLocationCommandHandler : IRequestHandler<SetCurrentLocationCommand, SetCurrentLocationCommandResponse>
    {
        private readonly ICarrierLocationService _carrierLocationService;

        public SetCurrentLocationCommandHandler(ICarrierLocationService carrierLocationService)
        {
            _carrierLocationService = carrierLocationService;
        }

        public async Task<SetCurrentLocationCommandResponse> Handle(SetCurrentLocationCommand request, CancellationToken cancellationToken)
        {
            await _carrierLocationService.SetCurrentAsync(request.Latitude, request.Longitude);
            return new();
        }
    }
}
