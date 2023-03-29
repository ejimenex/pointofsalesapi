using AutoMapper;
using PointOfSales.Application.Contracts.Persistence;
using MediatR;

namespace PointOfSales.Application.Features.Client.Queries.GetClientPaged
{
    public class GetClientPagedHandler : IRequestHandler<GetClientPagedQuery, GetClintPageVm>
    {
        private readonly IClientRepository clientRepository;
        private readonly IMapper mapper;
        public GetClientPagedHandler(IMapper mapper, IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
            this.mapper = mapper;
        }
        public async Task<GetClintPageVm> Handle(GetClientPagedQuery request, CancellationToken cancellationToken)
        {
            var list = await this.clientRepository.GetPaged(request.Filter, request.Page, request.Size);
            var client = mapper.Map<List<ClientPagedDto>>(list);
            var count = await this.clientRepository.GetTotalCount(request.Filter);
            return new GetClintPageVm()
            {
                Count = count,
                Size = request.Size,
                Page = request.Page,
                Data = client
            };

        }
    }
}
