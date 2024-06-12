namespace PDI.Domain.Entities
{
    public class Product() : Entity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool Active { get; set; } = default!;
        public Category Category { get; set; } = default!;
    }
}
