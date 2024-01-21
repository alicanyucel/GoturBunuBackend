using GoturBunu.Application.Services.Data;
using GoturBunu.Domain.Entities;
using GoturBunu.Persistance.Context;

namespace GoturBunu.Persistance.Services
{
    public class TestRepository : BaseEntityRepository<Test, string, GoturBunuContext>, ITestRepository
    {
        public TestRepository(GoturBunuContext context) : base(context)
        { }

        public List<Test> SignificantTestEntities()
        {
            // implement logic using context here...
            throw new NotImplementedException();
        }
    }
}
