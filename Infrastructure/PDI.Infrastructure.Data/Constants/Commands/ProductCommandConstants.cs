namespace PDI.Infrastructure.Data.Constants.Commands
{
    public static class ProductCommandConstants
    {
        public const string CreateProductCommand = @"INSERT INTO Product (Id, Name, Description, Active, CategoryId) VALUES (@Id, @Name, @Description, @Active, @CategoryId);";
        public const string UpdateProductCommand = @"UPDATE Product SET Name = @Name, Description = @Description, Active = @Active, CategoryId = @CategoryId WHERE Id = @Id";
        public const string DeleteProductCommand = @"DELETE Product WHERE Id = @id";
    }
}
