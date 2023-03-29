using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.UnitOfMeasure.Queries.All
{
    public class UnitOfMeasureQueryHandler:IRequestHandler<UnitOfMeasureQuery,List<UnitOfMeasureVm>>
    {
        private readonly IAsyncRepository<InternalParamUnitOfMeasure> unitOfMeasureRepository;
        private readonly IMapper mapper;
        public UnitOfMeasureQueryHandler(IMapper mapper,IAsyncRepository<InternalParamUnitOfMeasure> unitOfMeasureRepository)
        {
            this.mapper = mapper;
            this.unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<List<UnitOfMeasureVm>> Handle(UnitOfMeasureQuery request, CancellationToken cancellationToken)
        {
            var result = mapper.Map<List<UnitOfMeasureVm>>(await unitOfMeasureRepository.ListAllAsync());
            return result;
        }
    }
}
