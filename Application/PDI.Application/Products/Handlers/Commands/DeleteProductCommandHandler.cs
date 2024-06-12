using MediatR;
using PDI.Application.Products.Commands;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Products.Handlers.Commands
{
    public class DeleteProductCommandHandler(IProductRepository productRepository) : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.DeleteAsync(request.Id);
        }
    }
}
