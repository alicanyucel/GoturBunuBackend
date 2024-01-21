using MediatR;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed record class SetCurrentLocationCommand(
         double Latitude,
         double Longitude
     ) : IRequest<SetCurrentLocationCommandResponse>;
}
