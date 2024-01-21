using MediatR;
using GoturBunu.Domain.Entities;

namespace GoturBunu.Application.Features.Store
{

    public sealed record class CreateRegistryRequestCommand(
        string StoreName,
        string Name,
        string Surname,
        string NationalIdentityNumber,
        string Phone,
        string Email,
        ERegisteryRequestStatus status,
        string DistrictId
    ) : IRequest<CreateRegistryRequestCommandResponse>;
}
