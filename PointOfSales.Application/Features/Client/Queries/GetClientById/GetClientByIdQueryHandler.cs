namespace PointOfSales.Application.Features.Client.Queries.GetClientById
{
    public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, GetClientByIdVm>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Domain.Entities.Client> clientRepository;

        public GetClientByIdQueryHandler(IMapper mapper, IAsyncRepository<Domain.Entities.Client> clientRepository)
        {
            this.mapper = mapper;
            this.clientRepository = clientRepository;
        }

        public async Task<GetClientByIdVm> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await clientRepository.GetByIdAsync(request.Id);
            return mapper.Map<GetClientByIdVm>(client);
        }
    }
}
