using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Command.DeleteProviderCommand
{
    public class DeleteProviderCommand:IRequest
    {
        public Guid Id { get; set; }    
    }
}
