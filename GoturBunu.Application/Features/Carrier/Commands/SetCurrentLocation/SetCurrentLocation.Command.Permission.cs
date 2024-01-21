using GoturBunu.Application.Security;
using MediatR;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed record class SetCurrentLocationCommandPermission() : ICarrierPermission;
}
