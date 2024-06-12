using MediatR;
using PDI.Application.Extensions;
using PDI.Application.Transactions.Commands;
using PDI.Infrastructure.Data.Interfaces;

namespace PDI.Application.Transactions.Handlers.Commands
{
    public class CreateTransactionCommandHandler(ITransactionRepository transactionRepository) : IRequestHandler<CreateTransactionCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository = transactionRepository;
        public async Task<bool> Handle(CreateTransactionCommand command, CancellationToken cancellationToken)
        {
            return await _transactionRepository.CreateAsync(command.MapCreateTransactionCommandToEntity());
        }
    }
}
