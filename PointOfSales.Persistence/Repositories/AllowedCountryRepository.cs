using PointOfSales.Application.Contracts.Persistence;
using PointOfSales.Application.Features.AllowedCountries.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Persistence.Repositories
{
    public class AllowedCountryRepository : BaseRepository<InternalParamAllowredCountry>
    {
        public AllowedCountryRepository(PointOfSalesDbContext context) : base(context)
        {

        }

    }
}
