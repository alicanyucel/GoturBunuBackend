using MediatR;
using GoturBunu.Application.Services;
using GoturBunu.Application.Services.Data;

namespace GoturBunu.Application.Features.Test.Queries
{
    public sealed class GetTestDataListQueryHandler : IRequestHandler<GetTestDataListQuery, GetTestDataListQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITestRepository _testRepository;

        public GetTestDataListQueryHandler(ITestRepository testRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _testRepository = testRepository;
        }

        public async Task<GetTestDataListQueryResponse> Handle(GetTestDataListQuery request, CancellationToken cancellationToken)
        {
            var testDataList = await _testRepository.GetListAsync(t => new TestDataOnlyDto
            {
                Data = t.Data
            });

            return new(testDataList);
        }
    }
}
