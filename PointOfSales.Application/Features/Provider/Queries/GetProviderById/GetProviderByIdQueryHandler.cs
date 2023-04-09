using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Queries.GetProviderById
{
    public class GetProviderByIdQueryHandler:IRequestHandler<GetProviderByIdQuery,GetProviderByIdVm>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Domain.Entities.Supplier> providerRepository;

        public GetProviderByIdQueryHandler(IMapper mapper, IAsyncRepository<Domain.Entities.Supplier> providerRepository)
        {
            this.mapper = mapper;
            this.providerRepository = providerRepository;   
        }

        public async Task<GetProviderByIdVm> Handle(GetProviderByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await providerRepository.GetByIdAsync(request.Id);
            return mapper.Map<GetProviderByIdVm>(client);
        }
    }
}
