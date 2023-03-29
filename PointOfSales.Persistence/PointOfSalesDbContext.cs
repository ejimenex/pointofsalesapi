using PointOfSales.Domain.Common;
using PointOfSales.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace PointOfSales.Persistence
{
    public class PointOfSalesDbContext : DbContext
    {
        public PointOfSalesDbContext(DbContextOptions<PointOfSalesDbContext> options) : base(options)
        {

        }
        public DbSet<Event> Event { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<UserRegistrered> UserRegistrered { get; set; }
        public DbSet<InternalParamAllowredCountry> InternalParamAllowredCountry { get; set; }
        public DbSet<InternalParamaLanguage> InternalParamaLanguage { get; set; }
        public DbSet<InternalParamCurrency> InternalParamCurrency { get; set; }
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
                        entry.Entity.UserEmail = "edgarj.galvan@gmail.com";
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
