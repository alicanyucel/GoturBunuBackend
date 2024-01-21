using GoturBunu.Domain.Entities;

namespace GoturBunu.Application.Services.Data
{
    public interface ITestRepository : IEntityRepository<Test, string>
    {
        // test specific methods here..
        // implementations under "Presistance"

        // ex:
        List<Test> SignificantTestEntities();
    }
}
