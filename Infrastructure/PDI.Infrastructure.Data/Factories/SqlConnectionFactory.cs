using PDI.Domain.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace PDI.Infrastructure.Data.Factories
{
    public class SqlConnectionFactory(string connectionString) : IDbConnectionFactory
    {
        private readonly string _connectionString = connectionString;

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
