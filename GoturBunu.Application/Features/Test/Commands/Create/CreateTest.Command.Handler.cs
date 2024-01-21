using MediatR;
using AutoMapper;
using GoturBunu.Application.Services;
using GoturBunu.Application.Services.Data;
using Microsoft.AspNetCore.Authorization;

namespace GoturBunu.Application.Features.Test
{
    public sealed class CreateTestCommandHandler : IRequestHandler<CreateTestCommand, CreateTestCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITestRepository _testRepository;
        public CreateTestCommandHandler(IMapper mapper, ITestRepository testRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _testRepository = testRepository;
        }

        public async Task<CreateTestCommandResponse> Handle(CreateTestCommand request, CancellationToken cancellationToken)
        {
            var newTest = new Domain.Entities.Test
            {
                Data = request.Data,
                Name = request.Name
            };

            _testRepository.Add(newTest);
            await _unitOfWork.SaveChangesAsync();

            var created = _mapper.Map<TestDataOnlyDto>(newTest);
            return new(created);
        }
    }
}
