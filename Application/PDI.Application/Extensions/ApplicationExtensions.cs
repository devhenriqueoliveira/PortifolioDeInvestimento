using Microsoft.Extensions.DependencyInjection;
using PDI.Application.Investments.Commands;
using PDI.Application.Investments.Queries;

namespace PDI.Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(GetAllInvestmentsQuery).Assembly));
            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(CreateInvestmentCommand).Assembly));

            return services;
        }
    }
}
