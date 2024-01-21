
namespace GoturBunu.Domain.Core
{
    public interface ITraceableEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }
    }

}
