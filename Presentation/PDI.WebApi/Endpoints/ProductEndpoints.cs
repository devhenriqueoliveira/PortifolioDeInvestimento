using MediatR;
using Microsoft.AspNetCore.Mvc;
using PDI.Application.Products.Commands;
using PDI.Application.Products.Queries;

namespace PDI.WebApi.Endpoints
{
    public static class ProductEndpoints
    {
        public static void MapProductEndpoints(this WebApplication app)
        {
            app.MapGet("/product/{id}", async (Guid id, IMediator mediator) =>
            {
                var query = new GetByIdProductQuery(id);
                var result = await mediator.Send(query);
                return Results.Ok(result);
            }).CacheOutput();

            app.MapGet("/product", async (IMediator mediator) =>
            {
                var query = new GetAllProductQuery();
                var result = await mediator.Send(query);
                return Results.Ok(result);
            }).CacheOutput();

            app.MapPost("/product", async (CreateProductCommand command, IMediator mediator) =>
            {
                var result = await mediator.Send(command);
                return Results.Created($"Produto Criado com Sucesso!", result);
            });

            app.MapPut("/product/{id}", async (Guid id, UpdateProductCommand command, IMediator mediator) =>
            {
                if (id.ToString() != command.Id) return Results.BadRequest();

                var result = await mediator.Send(command);
                if (!result) return Results.BadRequest();

                return Results.NoContent();
            });

            app.MapDelete("/product/{id}", async (Guid id, [FromBody] DeleteProductCommand command, IMediator mediator) =>
            {
                command = command with { Id = id };

                var result = await mediator.Send(command);
                if (!result) return Results.NotFound();

                return Results.NoContent();
            });
        }
    }
}
