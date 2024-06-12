using PDI.Domain.Entities;
using PDI.Domain.Interfaces;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Infrastructure.Data.Repositories
{
    public class TransactionRepository(IDbConnectionFactory dbConnectionFactory) : ITransactionRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory = dbConnectionFactory;

        public async Task<bool> CreateAsync(Transaction value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Transaction value)
        {
            throw new NotImplementedException();
        }
    }
}