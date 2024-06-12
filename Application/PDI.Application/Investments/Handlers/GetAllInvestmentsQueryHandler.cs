using MediatR;
using PDI.Application.Investments.Queries;
using PDI.Domain.Entities;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Investments.Handlers
{
    public class GetAllInvestmentsQueryHandler(IInvestmentRepository investmentRepository) : IRequestHandler<GetAllInvestmentsQuery, IEnumerable<Investment>>
    {
        private readonly IInvestmentRepository _investmentRepository = investmentRepository;

        public async Task<IEnumerable<Investment>> Handle(GetAllInvestmentsQuery query, CancellationToken cancellationToken)
        {
            return await _investmentRepository.GetAllAsync();
        }
    }
}
