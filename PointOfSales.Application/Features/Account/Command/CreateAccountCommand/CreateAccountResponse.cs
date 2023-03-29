using PointOfSales.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Account.Command.CreateAccountCommand
{
    public class CreateAccountResponse:BaseResponse
    {
        public CreateAccountResponse() : base() { }
        public CreateAccountDto UserRegistrered { get; set; } = default;
    }
}
