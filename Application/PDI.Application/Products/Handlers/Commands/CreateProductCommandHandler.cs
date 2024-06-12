using MediatR;
using PDI.Application.Extensions;
using PDI.Application.Products.Commands;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Products.Handlers.Commands
{
    public class CreateProductCommandHandler(IProductRepository productRepository) : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<bool> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            return await _productRepository.CreateAsync(command.MapCreateProductCommandToEntity());
        }
    }
}
