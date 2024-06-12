using MediatR;
using PDI.Application.Extensions;
using PDI.Application.Products.Commands;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Products.Handlers.Commands
{
    public class UpdateProductCommandHandler(IProductRepository productRepository) : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.UpdateAsync(request.MapUpdateProductCommandToEntity());
        }
    }
}
