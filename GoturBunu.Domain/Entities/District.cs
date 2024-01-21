using GoturBunu.Domain.Core;

namespace GoturBunu.Domain.Entities
{
    public class District : BaseEntity<string>
    {
        public string Name { get; set; }

        public Province Province { get; set; }
    }
}
