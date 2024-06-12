using MediatR;
using PDI.Application.Investments.Commands;
using PDI.Application.Investments.Queries;
using PDI.Domain.Entities;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Investments.Handlers
{
    public class CreateInvestmentCommandHandler(IInvestmentRepository investmentRepository) : IRequestHandler<CreateInvestmentCommand, Investment>
    {
        private readonly IInvestmentRepository _investmentRepository = investmentRepository;

        public async Task<Investment> Handle(CreateInvestmentCommand command, CancellationToken cancellationToken)
        {
            var investment = new Investment
            {
                Name = command.Name,
                Value = command.CurrentValue,
            };

            await _investmentRepository.CreateAsync(investment);
            return investment;
        }
    }
}
