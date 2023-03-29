using PointOfSales.Application.Features.Account.Command.CreateAccountCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<UserRegistrered, CreateAccountCommand>().ReverseMap();
            CreateMap<UserRegistrered, CreateAccountDto>().ReverseMap();
        }
    }
}
