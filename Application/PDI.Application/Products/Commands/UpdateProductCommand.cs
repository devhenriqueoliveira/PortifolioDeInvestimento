using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Products.Commands
{
    public record UpdateProductCommand(
        string Id,
        string Name,
        string Description,
        bool Active,
        Category Category) : IRequest<bool>;
}
