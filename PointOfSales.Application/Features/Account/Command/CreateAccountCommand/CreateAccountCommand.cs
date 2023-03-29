using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Account.Command.CreateAccountCommand
{
    public class CreateAccountCommand:IRequest<CreateAccountResponse>
    {
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public Guid? CountryId { get; set; }
		public string Password { get; set; }
		public string Language { get; set; }
	}
}
