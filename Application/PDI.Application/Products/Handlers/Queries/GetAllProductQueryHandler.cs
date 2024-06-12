using MediatR;
using PDI.Application.Products.Queries;
using PDI.Domain.Entities;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Products.Handlers.Queries
{
    public class GetAllProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<IEnumerable<Product>> Handle(GetAllProductQuery query, CancellationToken cancellationToken)
        {
            return await _productRepository.GetAllAsync();
        }
    }
}
