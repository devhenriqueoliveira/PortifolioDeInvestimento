using MediatR;
using PDI.Application.Transactions.Queries;
using PDI.Domain.Entities;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Products.Handlers.Queries
{
    public class GetByIdTransactionQueryHandler(ITransactionRepository transactionRepository) : IRequestHandler<GetByIdTransactionQuery, Transaction>
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;
        public async Task<Transaction> Handle(GetByIdTransactionQuery query, CancellationToken cancellationToken)
        {
            return await _transactionRepository.GetByIdAsync(query.Id);
        }
    }
}
