using MediatR;
using PDI.Domain.Entities;

namespace PDI.Application.Investments.Commands
{
    public record CreateInvestmentCommand(
        string Name, 
        string Type, 
        decimal CurrentValue, 
        DateTime ExpiryDate) : IRequest<Investment>;
}
