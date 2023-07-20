using PointOfSales.Application.Features.Service.Command.CreateService;
using PointOfSales.Application.Features.Service.Command.CreateServiceCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Profiles
{
    public class ServiceMapper:Profile
    {
        public ServiceMapper()
        {
              CreateMap<Client, CreateServiceDto>().ReverseMap();
              CreateMap<Client, CreateServiceCommand>().ReverseMap();     
        }
     
    }
}
