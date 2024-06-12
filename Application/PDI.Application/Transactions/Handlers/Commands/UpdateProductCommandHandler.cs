using MediatR;
using PDI.Application.Extensions;
using PDI.Application.Transactions.Commands;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Transactions.Handlers.Commands
{
    public class UpdateTransactionCommandHandler(ITransactionRepository transactionRepository) : IRequestHandler<UpdateTransactionCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;
        public async Task<bool> Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
        {
            return await _transactionRepository.UpdateAsync(request.MapUpdateTransactionCommandToEntity());
        }
    }
}
