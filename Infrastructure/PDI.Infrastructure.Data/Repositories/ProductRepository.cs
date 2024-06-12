using Dapper;
using PDI.Domain.Entities;
using PDI.Domain.Interfaces;
using PDI.Infrastructure.Data.Constants.Commands;
using PDI.Infrastructure.Data.Constants.Queries;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Infrastructure.Data.Repositories
{
    public class ProductRepository(IDbConnectionFactory dbConnectionFactory) : IProductRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory = dbConnectionFactory;
        public async Task<bool> CreateAsync(Product value)
        {
            try
            {
                using var connection = _dbConnectionFactory.CreateConnection();
                return await connection.ExecuteAsync(ProductCommandConstants.CreateProductCommand, new { value.Id, value .Name, value.Description, value.Active, CategoryId = value.Category.Id }) > 0;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                using var connection = _dbConnectionFactory.CreateConnection();
                return await connection.ExecuteAsync(ProductCommandConstants.DeleteProductCommand, new { id }) > 0;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            try
            {
                using var connection = _dbConnectionFactory.CreateConnection();
                return await connection.QueryAsync<Product>(ProductQueryConstants.GetAllProductQuery);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            try
            {
                using var connection = _dbConnectionFactory.CreateConnection();
                return await connection.QuerySingleAsync<Product>(ProductQueryConstants.GetByIdProductQuery, new { id });
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<bool> UpdateAsync(Product value)
        {
            try
            {
                using var connection = _dbConnectionFactory.CreateConnection();
                return await connection.ExecuteAsync(ProductCommandConstants.UpdateProductCommand, new { value.Id, value.Name, value.Description, value.Active, CategoryId = value.Category.Id }) > 0;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
