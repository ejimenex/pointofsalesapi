using PointOfSales.Application.Exceptions;

namespace PointOfSales.Application.Features.Client.Command.CreateProvider
{
    public class CreateProviderCommandHandler : IRequestHandler<CreateProviderCommand, CreateProviderCommandResponse>
    {
        private readonly IProviderRepository providerRepository;
        private readonly IMapper _mapper;
        public CreateProviderCommandHandler(IProviderRepository clientRepository, IMapper mapper)
        {
            this.providerRepository = clientRepository;
            _mapper = mapper;
        }
        public async Task<CreateProviderCommandResponse> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
        {

            var createProviderResponse = new CreateProviderCommandResponse();
            var validator = new CreateProviderCommandValidation(this.providerRepository);
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                createProviderResponse.Success = false;
                throw new ValidationException(validationResult);
            }
            if (createProviderResponse.Success)
            {
                var client = _mapper.Map<Domain.Entities.Supplier>(request);
                client = await providerRepository.AddAsync(client);
                createProviderResponse.Client = _mapper.Map<CreateProviderDto>(client);
            }
            return createProviderResponse;

        }
    }
}
