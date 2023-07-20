using PointOfSales.Application.Exceptions;
using PointOfSales.Application.Features.Service.Command.CreateServiceCommand;

namespace PointOfSales.Application.Features.Service.Command.CreateService
{
    public class CreateClientCommandHandler : IRequestHandler<CreateServiceCommand, CreateServiceCommandResponse>
    {
        private readonly IServiceRepository serviceRepository;
        private readonly IMapper _mapper;
        public CreateClientCommandHandler(IServiceRepository serviceRepository, IMapper mapper)
        {
            this.serviceRepository = serviceRepository;
            _mapper = mapper;
        }
        public async Task<CreateServiceCommandResponse> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var createServiceResponse = new CreateServiceCommandResponse();
            var validator = new CreateServiceCommandValidation(this.serviceRepository);
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                createServiceResponse.Success = false;
                throw new ValidationException(validationResult);
            }
            if (createServiceResponse.Success)
            {
                var client = _mapper.Map<Domain.Entities.Product>(request);
                client = await serviceRepository.AddAsync(client);
                createServiceResponse.Product = _mapper.Map<CreateServiceDto>(client);
            }
            return createServiceResponse;

        }
    }
}
