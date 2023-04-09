using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Queries.GetProviderById
{
    public class GetProviderByIdQuery:IRequest<GetProviderByIdVm>
    {
        public Guid Id { get; set; }
    }
}
