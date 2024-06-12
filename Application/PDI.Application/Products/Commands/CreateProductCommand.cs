using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Products.Commands
{
    public record CreateProductCommand(
        string Name,
        string Description,
        bool Active,
        Category Category) : IRequest<bool>;
}
