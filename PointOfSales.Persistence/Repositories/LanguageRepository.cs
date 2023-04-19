namespace PointOfSales.Persistence.Repositories
{
    public class LanguageRepository : BaseRepository<Language>
    {
        public LanguageRepository(PointOfSalesDbContext context) : base(context)
        {

        }

    }
}
