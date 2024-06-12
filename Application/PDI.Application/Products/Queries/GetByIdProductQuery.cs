using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Products.Queries
{
    public record GetByIdProductQuery(Guid Id) : IRequest<Product>;
}
