using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Queries.GetClientById
{
    public class GetClientByIdQuery:IRequest<GetClientByIdVm>
    {
        public Guid Id { get; set; }
    }
}
