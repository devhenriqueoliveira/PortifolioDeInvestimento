using PDI.Domain.Interfaces;
using PDI.Infrastructure.Data.Factories;
using PDI.Infrastructure.Data.Interfaces;
using PDI.Infrastructure.Data.Repositories;
using PDI.Application.Products.Queries;
using PDI.Application.Products.Commands;
using PDI.Application.Transactions.Queries;
using PDI.Application.Transactions.Commands;
using PDI.WebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSingleton<IDbConnectionFactory>(new SqlConnectionFactory(connectionString!));
builder.Services.AddScoped<IInvestmentRepository, InvestmentRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddMemoryCache();

builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetAllTransactionQuery).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetByIdTransactionQuery).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(CreateTransactionCommand).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(UpdateTransactionCommand).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(DeleteTransactionCommand).Assembly));

builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetAllProductQuery).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetByIdProductQuery).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(CreateProductCommand).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(UpdateProductCommand).Assembly));
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(DeleteProductCommand).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapProductEndpoints();
app.MapTransactionEndpoints();

app.Run();