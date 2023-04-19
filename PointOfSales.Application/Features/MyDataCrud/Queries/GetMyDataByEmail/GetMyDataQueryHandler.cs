using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.MyDataCrud.Queries.GetMyDataByEmail
{
    public class GetMyDataQueryHandler:IRequestHandler<MyDataByEmailQuery,GetByEmailVm>

    {
        private readonly IMyDataRepository myDataRepository;
        private readonly IMapper mapper;
        public GetMyDataQueryHandler(IMapper mapper,IMyDataRepository myDataRepository)
        {
            this.mapper = mapper;
            this.myDataRepository = myDataRepository;
        }

        public async Task<GetByEmailVm> Handle(MyDataByEmailQuery request, CancellationToken cancellationToken)
        {
            var myData = await myDataRepository.GetOne();
            return mapper.Map<GetByEmailVm>(myData);
        }
    }
}
