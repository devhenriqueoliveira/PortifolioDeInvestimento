using PDI.Domain.Enums;

namespace PDI.Domain.Entities
{
    public class Transaction : Entity
    {
        public TransactionTypeEnum Type { get; set; } = default!;
        public decimal Amount { get; set; } = default!;
        public Customer Customer { get; set; } = default!;
        public Product Product { get; set; } = default!;
    }
}
