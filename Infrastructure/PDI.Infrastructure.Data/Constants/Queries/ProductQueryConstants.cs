namespace PDI.Infrastructure.Data.Constants.Queries
{
    public static class ProductQueryConstants
    {
        public const string GetAllProductQuery = @"SELECT * FROM Product";
        public const string GetByIdProductQuery = @"SELECT * FROM Product WHERE Id = @id";
    }
}
