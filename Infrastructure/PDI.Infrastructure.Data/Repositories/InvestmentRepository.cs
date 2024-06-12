using Dapper;
using PDI.Domain.Entities;
using PDI.Domain.Interfaces;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Infrastructure.Data.Repositories
{
    public class InvestmentRepository(IDbConnectionFactory dbConnectionFactory) : IInvestmentRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory = dbConnectionFactory;

        public async Task<bool> CreateAsync(Investment value)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            const string sql = "INSERT INTO Investment (Id, Name, Type, Value, ExpiryDate) VALUES (@Id, @Name, @Type, @Value, @ExpiryDate);" +
                               "SELECT CAST(SCOPE_IDENTITY() as int)";
            return await connection.ExecuteScalarAsync<bool>(sql, value);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Investment>> GetAllAsync()
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            const string sql = "SELECT * FROM Investment";
            return await connection.QueryAsync<Investment>(sql);
        }

        public Task<Investment> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Investment value)
        {
            throw new NotImplementedException();
        }
    }
}
