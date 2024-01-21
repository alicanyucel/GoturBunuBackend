
namespace GoturBunu.Domain.Core
{
    public interface IEntity<T>
        where T : IComparable
    {
        T Id { get; set; }
    }
}
