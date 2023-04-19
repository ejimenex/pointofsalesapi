using PointOfSales.Application.Features.Client.Command.CreateProvider;
using PointOfSales.Application.Features.Client.Command.UpdateProvider;
using PointOfSales.Application.Features.Client.Queries.GetProviderById;
using PointOfSales.Application.Features.Client.Queries.GetProviderPaged;

namespace PointOfSales.Application.Profiles
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile()
        {
            CreateMap<Supplier, CreateProviderDto>().ReverseMap();
            CreateMap<Supplier, CreateProviderCommand>().ReverseMap();

            CreateMap<Supplier, ProviderPagedDto>();
            CreateMap<Supplier, GetProviderPageVm>().ReverseMap();

            CreateMap<Supplier, UpdateProviderCommand>().ReverseMap();

            CreateMap<Supplier, GetProviderByIdVm>();
        }

    }
}
