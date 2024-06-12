using MediatR;
using PDI.Application.Transactions.Queries;
using PDI.Domain.Entities;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Transactions.Handlers.Queries
{
    public class GetAllTransactiontQueryHandler(ITransactionRepository transactionRepository) : IRequestHandler<GetAllTransactionQuery, IEnumerable<Transaction>>
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task<IEnumerable<Transaction>> Handle(GetAllTransactionQuery query, CancellationToken cancellationToken)
        {
            return await _transactionRepository.GetAllAsync();
        }
    }
}
