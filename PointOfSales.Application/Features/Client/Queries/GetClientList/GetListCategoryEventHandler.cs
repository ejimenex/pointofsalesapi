namespace PointOfSales.Application.Features.Client.Queries.GetClientList
{
    public class GetListClientEventHandler : IRequestHandler<GetClientQuery, List<GetClientListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Domain.Entities.Client> clientRepository;
        public GetListClientEventHandler(IMapper mapper, IAsyncRepository<Domain.Entities.Client> clientRepository)
        {
            this.mapper = mapper;
            this.clientRepository = clientRepository;

        }
        public async Task<List<GetClientListVm>> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var category = await clientRepository.ListAllAsync();
            return mapper.Map<List<GetClientListVm>>(category);
        }


    }
}
