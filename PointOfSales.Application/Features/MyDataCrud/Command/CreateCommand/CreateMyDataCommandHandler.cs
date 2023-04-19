namespace PointOfSales.Application.Features.MyDataCrud.Command.CreateCommand
{
    public class CreateMyDataCommandHandler:IRequestHandler<CreateMyDataCommand,Guid>
    {
        private readonly IMyDataRepository myDataRepository;
        private readonly IMapper mapper;
        public CreateMyDataCommandHandler(IMyDataRepository myDataRepository, IMapper mapper)
        {

            this.myDataRepository = myDataRepository;   
            this.mapper = mapper;

        }

        public async Task<Guid> Handle(CreateMyDataCommand request, CancellationToken cancellationToken)
        {
            var @myData = mapper.Map<MyData>(request);
            var validator = new CreateMyDataValidation();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            @myData = await myDataRepository.AddAsync(@myData);
            return @myData.Id;
        }
    }
}
