using PointOfSales.Application.Features.UnitOfMeasure.Queries.All;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Profiles
{
    public class UnitOfMeasureProfile:Profile
    {
        public UnitOfMeasureProfile()
        {
            CreateMap<InternalParamUnitOfMeasure, UnitOfMeasureVm>();
        }
    }
}
