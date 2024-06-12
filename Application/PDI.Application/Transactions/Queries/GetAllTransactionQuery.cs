using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Transactions.Queries
{
    public record GetAllTransactionQuery() : IRequest<IEnumerable<Transaction>>;
}
