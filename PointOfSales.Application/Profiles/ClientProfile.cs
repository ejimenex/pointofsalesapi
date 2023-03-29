using PointOfSales.Application.Features.Client.Command.CreateClient;
using PointOfSales.Application.Features.Client.Command.UpdateCommand;
using PointOfSales.Application.Features.Client.Queries.GetClientById;
using PointOfSales.Application.Features.Client.Queries.GetClientList;
using PointOfSales.Application.Features.Client.Queries.GetClientPaged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Profiles
{
    public class ClientProfile:Profile
    {
        public ClientProfile()
        {
         CreateMap<Client, CreateClientDto>().ReverseMap();
        CreateMap<Client, CreateClientCommand>().ReverseMap();

            CreateMap<Client, ClientPagedDto>();
            CreateMap<Client, GetClintPageVm>().ReverseMap();

            CreateMap<Client, GetClientListVm>().ReverseMap();

            CreateMap<Client, UpdateClientCommand>().ReverseMap();

            CreateMap<Client, GetClientByIdVm>();
        }
        
    }
}
