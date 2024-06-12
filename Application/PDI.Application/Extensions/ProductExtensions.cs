using PDI.Application.Products.Commands;
using PDI.Domain.Entities;

namespace PDI.Application.Extensions
{
    public static class ProductExtensions
    {
        public static Product MapCreateProductCommandToEntity(this CreateProductCommand command)
        {
            return new Product() 
            {
                Name = command.Name,
                Description = command.Description,
                Active = command.Active,
                Category = command.Category
            };
        }
        public static Product MapUpdateProductCommandToEntity(this UpdateProductCommand command)
        {
            return new Product()
            {
                Id = new Guid(command.Id),
                Name = command.Name,
                Description = command.Description,
                Active = command.Active,
                Category = command.Category
            };
        }
    }
}
