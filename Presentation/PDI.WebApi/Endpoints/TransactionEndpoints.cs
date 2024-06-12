using MediatR;
using Microsoft.AspNetCore.Mvc;
using PDI.Application.Transactions.Commands;
using PDI.Application.Transactions.Queries;

namespace PDI.WebApi.Endpoints
{
    public static class TransactionEndpoints
    {
        public static void MapTransactionEndpoints(this WebApplication app)
        {
            app.MapGet("/transaction/{id}", async (Guid id, IMediator mediator) =>
            {
                var query = new GetByIdTransactionQuery(id);
                var result = await mediator.Send(query);
                return Results.Ok(result);
            }).CacheOutput();

            app.MapGet("/transaction", async (IMediator mediator) =>
            {
                var query = new GetAllTransactionQuery();
                var result = await mediator.Send(query);
                return Results.Ok(result);
            }).CacheOutput();

            app.MapPost("/transaction", async (CreateTransactionCommand command, IMediator mediator) =>
            {
                var result = await mediator.Send(command);
                return Results.Created($"Produto Criado com Sucesso!", result);
            });

            app.MapPut("/transaction/{id}", async (Guid id, UpdateTransactionCommand command, IMediator mediator) =>
            {
                if (id.ToString() != command.Id) return Results.BadRequest();

                var result = await mediator.Send(command);
                if (!result) return Results.BadRequest();

                return Results.NoContent();
            });

            app.MapDelete("/transaction/{id}", async (Guid id, [FromBody] DeleteTransactionCommand command, IMediator mediator) =>
            {
                command = command with { Id = id };

                var result = await mediator.Send(command);
                if (!result) return Results.NotFound();

                return Results.NoContent();
            });
        }
    }
}
