namespace PointOfSales.Persistence.Repositories
{
    public class AllowedCountryRepository : BaseRepository<InternalParamAllowredCountry>
    {
        public AllowedCountryRepository(PointOfSalesDbContext context) : base(context)
        {

        }

    }
}
