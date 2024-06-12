using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Investments.Queries
{
    public record GetAllInvestmentsQuery() : IRequest<IEnumerable<Investment>>;
}
