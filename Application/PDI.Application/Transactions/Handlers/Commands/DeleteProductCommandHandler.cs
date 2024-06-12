using MediatR;
using PDI.Application.Transactions.Commands;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Transactions.Handlers.Commands
{
    public class DeleteTransactionCommandHandler(ITransactionRepository transactionRepository) : IRequestHandler<DeleteTransactionCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;

        public async Task<bool> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
        {
            return await _transactionRepository.DeleteAsync(request.Id);
        }
    }
}
