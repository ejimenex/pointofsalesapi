using PointOfSales.Application.Contracts.Persistence;
using PointOfSales.Application.Features.AllowedCountries.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Persistence.Repositories
{
    public class LanguageRepository : BaseRepository<Language>
    {
        public LanguageRepository(PointOfSalesDbContext context) : base(context)
        {

        }

    }
}
