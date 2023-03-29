using PointOfSales.Application.Contracts.Persistence;
using PointOfSales.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PointOfSales.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PointOfSalesDbContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("Context")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IAccountRepository, UserAccountRepository>();
            // services.AddScoped<IAsyncRepository<AllowedCountryRepository>, AllowedCountryRepository>();
            return services;
        }
    }
}
