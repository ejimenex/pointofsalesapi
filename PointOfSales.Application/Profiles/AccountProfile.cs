using PointOfSales.Application.Features.Account.Command.CreateAccountCommand;

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
