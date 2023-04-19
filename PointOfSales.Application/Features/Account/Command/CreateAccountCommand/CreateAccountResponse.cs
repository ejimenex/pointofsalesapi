using PointOfSales.Application.Responses;

namespace PointOfSales.Application.Features.Account.Command.CreateAccountCommand
{
    public class CreateAccountResponse : BaseResponse
    {
        public CreateAccountResponse() : base() { }
        public CreateAccountDto UserRegistrered { get; set; } = default;
    }
}
