using PointOfSales.Application.Features.MyDataCrud.Command.CreateCommand;
using PointOfSales.Application.Features.MyDataCrud.Command.UpdateCommand;
using PointOfSales.Application.Features.MyDataCrud.Queries.GetMyDataByEmail;

namespace PointOfSales.Application.Profiles
{
    public class MyDataProfile : Profile
    {
        public MyDataProfile()
        {
            CreateMap<MyData, CreateMyDataCommand>().ReverseMap();
            CreateMap<MyData, MyDataUpdateCommand>().ReverseMap();
            CreateMap<MyData, GetByEmailVm>();
        }
    }
}
