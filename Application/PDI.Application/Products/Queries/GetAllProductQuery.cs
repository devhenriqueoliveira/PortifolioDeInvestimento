using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Products.Queries
{
    public record GetAllProductQuery() : IRequest<IEnumerable<Product>>;
}
