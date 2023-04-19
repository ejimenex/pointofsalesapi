using PointOfSales.Domain.Common;
using PointOfSales.Persistence.Contract;

namespace PointOfSales.Persistence
{
    public class PointOfSalesDbContext : DbContext
    {
        private readonly ITokenRepository tokenRepository;
        public PointOfSalesDbContext(DbContextOptions<PointOfSalesDbContext> options, ITokenRepository tokenRepository) : base(options)
        {
            this.tokenRepository = tokenRepository;

        }
        public DbSet<Event> Event { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<UserRegistrered> UserRegistrered { get; set; }
        public DbSet<InternalParamAllowredCountry> InternalParamAllowredCountry { get; set; }
        public DbSet<InternalParamaLanguage> InternalParamaLanguage { get; set; }
        public DbSet<InternalParamCurrency> InternalParamCurrency { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<MyData> MyData { get; set; }
        public DbSet<InternalParamUnitOfMeasure> InternalParamUnitOfMeasure { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PointOfSalesDbContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.IsDeleted = false;
                        entry.Entity.UserEmail = tokenRepository.GetTokenData().Result.Email;
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }

}
