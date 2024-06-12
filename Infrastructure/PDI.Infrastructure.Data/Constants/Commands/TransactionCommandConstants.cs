namespace PDI.Infrastructure.Data.Constants.Commands
{
    public static class TransactionCommandConstants
    {
        public const string CreateTransactionCommand = @"INSERT INTO Transaction (Id, Type, Amount, CustomerId, ProductId) VALUES (@Id, @Type, @Amount, @CustomerId, @ProductId);";
        public const string UpdateTransactionCommand = @"UPDATE Product SET Name = @Name, Description = @Description, Active = @Active, CategoryId = @CategoryId WHERE Id = @Id";
        public const string DeleteTransactionCommand = @"DELETE Product WHERE Id = @id";
    }
}
