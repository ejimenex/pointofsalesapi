



using PointOfSales.Application.Exceptions;

namespace PointOfSales.Application.Features.Client.Command.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, CreateClientCommandResponse>
    {
        private readonly IClientRepository clientRepository;
        private readonly IMapper _mapper;
        public CreateClientCommandHandler(IClientRepository clientRepository, IMapper mapper)
        {
            this.clientRepository = clientRepository;
            _mapper = mapper;
        }
        public async Task<CreateClientCommandResponse> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var createClientResponse = new CreateClientCommandResponse();
            var validator = new CreateClientCommandValidation(this.clientRepository);
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                createClientResponse.Success = false;
                    throw new ValidationException(validationResult);
            }
            if (createClientResponse.Success)
            {
                var client = _mapper.Map<Domain.Entities.Client>(request) ;
                client = await clientRepository.AddAsync(client);
                createClientResponse.Client = _mapper.Map<CreateClientDto>(client);
            }
            return createClientResponse;

        }
    }
}
