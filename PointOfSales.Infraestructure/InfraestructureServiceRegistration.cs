using PointOfSales.Infraestructure.Email;
using PointOfSales.Application.Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace PointOfSales.Infraestructure
{
    public static class InfraestructureServiceRegistration
    {
        public static IServiceCollection AddInfraestructureService(this IServiceCollection services)

        {
            services.AddTransient<IEmailService, EmailServices>();
            return services;
        }
    }
}
