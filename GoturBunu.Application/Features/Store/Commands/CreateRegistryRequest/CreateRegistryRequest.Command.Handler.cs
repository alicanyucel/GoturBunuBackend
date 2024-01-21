using MediatR;
using GoturBunu.Application.Services;
using GoturBunu.Application.Services.Data;

namespace GoturBunu.Application.Features.Store
{
    public sealed class CreateRegistryRequestCommandHandler : IRequestHandler<CreateRegistryRequestCommand, CreateRegistryRequestCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStoreRegistryRequestRepository _storeRegistryRequestRepository;
        public CreateRegistryRequestCommandHandler(IStoreRegistryRequestRepository storeRegistryRequestRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _storeRegistryRequestRepository = storeRegistryRequestRepository;
        }

        public async Task<CreateRegistryRequestCommandResponse> Handle(CreateRegistryRequestCommand request, CancellationToken cancellationToken)
        {
            var newStoreRegistryRequest = new Domain.Entities.Store.StoreRegistryRequest
            {
                DistrictId = request.DistrictId,
                Email = request.Email,
                StoreName = request.StoreName,
                Name = request.Name,
                Surname = request.Surname,
                Status = request.status,
                NationalIdentityNumber = request.NationalIdentityNumber,
                CreatedAt = DateTime.Now,
                Phone = request.Phone
            };

            _storeRegistryRequestRepository.Add(newStoreRegistryRequest);
            await _unitOfWork.SaveChangesAsync();

            return new();
        }
    }
}
