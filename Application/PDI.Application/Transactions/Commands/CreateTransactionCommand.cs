using MediatR;
using PDI.Domain.Entities;
using PDI.Domain.Enums;

namespace PDI.Application.Transactions.Commands
{
    public record CreateTransactionCommand(
        TransactionTypeEnum Type,
        decimal Amount,
        Customer Customer,
        Product Product) : IRequest<bool>;
}
