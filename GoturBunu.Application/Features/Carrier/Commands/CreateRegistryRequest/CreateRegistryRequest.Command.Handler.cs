using MediatR;
using GoturBunu.Application.Services;
using GoturBunu.Application.Services.Data;

namespace GoturBunu.Application.Features.Carrier
{
    public sealed class CreateRegistryRequestCommandHandler : IRequestHandler<CreateRegistryRequestCommand, CreateRegistryRequestCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICarrierRegistryRequestRepository _carrierRegistryRequestRepository;
        public CreateRegistryRequestCommandHandler(IUnitOfWork unitOfWork, ICarrierRegistryRequestRepository carrierRegistryRequestRepository)
        {
            _unitOfWork = unitOfWork;
            _carrierRegistryRequestRepository = carrierRegistryRequestRepository;
        }

        public async Task<CreateRegistryRequestCommandResponse> Handle(CreateRegistryRequestCommand request, CancellationToken cancellationToken)
        {
            var newCarrierRegistryRequest = new Domain.Entities.Carrier.CarrierRegistryRequest
            {
                DistrictId = request.DistrictId,
                Email = request.Email,
                Name = request.Name,
                Surname = request.Surname,
                Status = request.status,
                NationalIdentityNumber = request.NationalIdentityNumber,
                CreatedAt = DateTime.Now,
                Phone = request.Phone
            };

            _carrierRegistryRequestRepository.Add(newCarrierRegistryRequest);
            await _unitOfWork.SaveChangesAsync();

            return new();
        }
    }
}
