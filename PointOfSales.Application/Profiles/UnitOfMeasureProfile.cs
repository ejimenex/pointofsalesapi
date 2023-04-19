using PointOfSales.Application.Features.UnitOfMeasure.Queries.All;

namespace PointOfSales.Application.Profiles
{
    public class UnitOfMeasureProfile : Profile
    {
        public UnitOfMeasureProfile()
        {
            CreateMap<InternalParamUnitOfMeasure, UnitOfMeasureVm>();
        }
    }
}
