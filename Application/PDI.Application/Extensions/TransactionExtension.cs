using PDI.Application.Transactions.Commands;
using PDI.Domain.Entities;

namespace PDI.Application.Extensions
{
    public static class TransactionExtension
    {
        public static Transaction MapCreateTransactionCommandToEntity(this CreateTransactionCommand command)
        {
            return new Transaction()
            {
                Type = command.Type,
                Amount = command.Amount,
                Customer = command.Customer,
                Product = command.Product
            };
        }
        public static Transaction MapUpdateTransactionCommandToEntity(this UpdateTransactionCommand command)
        {
            return new Transaction()
            {
                Id = new Guid(command.Id),
                Type = command.Type,
                Amount = command.Amount,
                Customer = command.Customer,
                Product = command.Product
            };
        }
    }
}
