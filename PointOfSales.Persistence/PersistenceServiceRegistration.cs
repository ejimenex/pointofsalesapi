using PointOfSales.Application.Contracts.Persistence;
using PointOfSales.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PointOfSales.Persistence.Contract;


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
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IAccountRepository, UserAccountRepository>();
            services.AddTransient<ITokenRepository, TokenRepo>();
            // services.AddScoped<IAsyncRepository<AllowedCountryRepository>, AllowedCountryRepository>();
            return services;
        }
    }
}
