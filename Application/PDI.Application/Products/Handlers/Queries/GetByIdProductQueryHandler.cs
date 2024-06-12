using MediatR;
using PDI.Application.Products.Queries;
using PDI.Domain.Entities;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Products.Handlers.Queries
{
    public class GetByIdProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetByIdProductQuery, Product>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<Product> Handle(GetByIdProductQuery query, CancellationToken cancellationToken)
        {
            return await _productRepository.GetByIdAsync(query.Id);
        }
    }
}
