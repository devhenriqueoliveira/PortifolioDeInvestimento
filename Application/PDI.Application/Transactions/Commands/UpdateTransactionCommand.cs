using MediatR;
using PDI.Domain.Entities;
using PDI.Domain.Enums;

namespace PDI.Application.Transactions.Commands
{
    public record UpdateTransactionCommand(
        string Id,
        TransactionTypeEnum Type,
        decimal Amount,
        Customer Customer,
        Product Product) : IRequest<bool>;
}
