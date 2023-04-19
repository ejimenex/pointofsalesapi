using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PointOfSales.Application.Infraestructure;
using PointOfSales.Infraestructure.Email;

namespace PointOfSales.Infraestructure
{
    public static class InfraestructureServiceRegistration
    {
        public static IServiceCollection AddInfraestructureService(this IServiceCollection services)

        {
            services.AddTransient<IEmailService, EmailServices>();
            services.AddTransient<ITokenService,TokenServices>();
            services.AddTransient<IHttpContextAccessor,HttpContextAccessor>();
            return services;
        }
    }
}
