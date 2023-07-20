using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PointOfSales.Persistence.Contract;
using PointOfSales.Persistence.Repositories;


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
            services.AddScoped<IServiceRepository, ProductRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IAccountRepository, UserAccountRepository>();
            services.AddScoped<IMyDataRepository, MyDataRepository>();
            services.AddTransient<ITokenRepository, TokenRepo>();
            return services;
        }
    }
}
