using AutoMapper;
using PointOfSales.Application.Contracts.Persistence;
using MediatR;
using PointOfSales.Application.Infraestructure;

namespace PointOfSales.Application.Features.Client.Queries.GetProviderPaged
{
    public class GetProviderPagedHandler : IRequestHandler<GetProviderPagedQuery, GetProviderPageVm>
    {
        private readonly IProviderRepository providerRepository;
        private readonly IMapper mapper;
        public GetProviderPagedHandler(IMapper mapper, 
        IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
            this.mapper = mapper;
        }
        public async Task<GetProviderPageVm> Handle(GetProviderPagedQuery request, CancellationToken cancellationToken)
        {
            var list = await this.providerRepository.GetPaged(request.Filter, request.Page, request.Size);
            var client = mapper.Map<List<ProviderPagedDto>>(list);
            var count = await this.providerRepository.GetTotalCount(request.Filter);
            return new GetProviderPageVm()
            {
                Count = count,
                Size = request.Size,
                Page = request.Page,
                Data = client
            };

        }
    }
}
