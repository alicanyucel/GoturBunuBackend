using MediatR;
using GoturBunu.Domain.Entities;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed record class CreateRegistryRequestCommand(
         string Name,
         string Surname,
         string NationalIdentityNumber,
         string Phone,
         string Email,
         ERegisteryRequestStatus status,
         string DistrictId
     ) : IRequest<CreateRegistryRequestCommandResponse>;
}
