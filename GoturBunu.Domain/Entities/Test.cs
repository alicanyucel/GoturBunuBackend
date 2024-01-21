using GoturBunu.Domain.Core;

namespace GoturBunu.Domain.Entities
{
    public class Test : BaseEntity<string>
    {
        public int Data { get; set; }
        public string Name { get; set; }
    }
}
