using PDI.Domain.Enums;

namespace PDI.Domain.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public RoleEnum Type { get; set; }
    }
}
