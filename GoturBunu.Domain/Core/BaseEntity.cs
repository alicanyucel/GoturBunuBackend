using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoturBunu.Domain.Core
{
    public abstract class BaseEntity<T> : IEntity<T>, ITraceableEntity
        where T : IComparable
    {
        [PrimaryKey]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
