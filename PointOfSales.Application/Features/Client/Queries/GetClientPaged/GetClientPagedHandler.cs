using AutoMapper;
using PointOfSales.Application.Contracts.Persistence;
using MediatR;
using PointOfSales.Application.Infraestructure;

namespace PointOfSales.Application.Features.Client.Queries.GetClientPaged
{
    public class GetClientPagedHandler : IRequestHandler<GetClientPagedQuery, GetClintPageVm>
    {
        private readonly IClientRepository clientRepository;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;
        public GetClientPagedHandler(IMapper mapper, 
        IClientRepository clientRepository,
        ITokenService tokenService)
        {
            this.clientRepository = clientRepository;
            this.mapper = mapper;
            this.tokenService = tokenService;
        }
        public async Task<GetClintPageVm> Handle(GetClientPagedQuery request, CancellationToken cancellationToken)
        {
            var user = (await tokenService.GetTokenData()).Email;
            var list = await this.clientRepository.GetPaged(request.Filter, request.Page, request.Size,user);
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
