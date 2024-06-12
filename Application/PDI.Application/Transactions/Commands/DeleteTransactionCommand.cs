using MediatR;

namespace PDI.Application.Transactions.Commands
{
    public record DeleteTransactionCommand(Guid Id) : IRequest<bool>;
}
