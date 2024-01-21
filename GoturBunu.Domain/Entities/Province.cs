using GoturBunu.Domain.Core;

namespace GoturBunu.Domain.Entities
{
    public class Province : BaseEntity<string>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
