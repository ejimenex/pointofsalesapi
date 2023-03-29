using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Account.Command.ChangePasswordCommand
{
    public class ChangePasswordAccountCommand:IRequest<bool>
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public Guid UserId { get; set; }
    }
}
