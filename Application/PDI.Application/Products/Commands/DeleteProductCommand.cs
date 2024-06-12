using MediatR;

namespace PDI.Application.Products.Commands
{
    public record DeleteProductCommand(Guid Id) : IRequest<bool>;
}
