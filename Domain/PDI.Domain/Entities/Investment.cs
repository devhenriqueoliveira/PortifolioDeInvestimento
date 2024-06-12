namespace PDI.Domain.Entities
{
    public class Investment : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public Product Product { get; set; }
    }
}
