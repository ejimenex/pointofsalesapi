using PointOfSales.Infraestructure.Email;
using PointOfSales.Application.Infraestructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace PointOfSales.Infraestructure
{
    public static class InfraestructureServiceRegistration
    {
        public static IServiceCollection AddInfraestructureService(this IServiceCollection services)

        {
               services.AddTransient<IEmailService, EmailServices>();
               services.AddTransient<ITokenService, TokenServices>();
               services.AddTransient<IHttpContextAccessor,HttpContextAccessor>();
            return services;
        }
    }
}
