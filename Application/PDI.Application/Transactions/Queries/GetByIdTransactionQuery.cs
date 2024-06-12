using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Transactions.Queries
{
    public record GetByIdTransactionQuery(Guid Id) : IRequest<Transaction>;
}
