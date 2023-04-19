namespace PointOfSales.Application.Features.MyDataCrud.Command.UpdateCommand
{
    public class UpdateMyDataCommandHandler:IRequestHandler<MyDataUpdateCommand>
    {
        private readonly IMyDataRepository myDataRepository;
        private readonly IMapper mapper;
        public UpdateMyDataCommandHandler(IMyDataRepository myDataRepository, IMapper mapper)
        {
            this.myDataRepository = myDataRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(MyDataUpdateCommand request, CancellationToken cancellationToken)
        {
            var dataToUpdate = await myDataRepository.GetByIdAsync(request.Id);
            var validator = new UpdateMyDataValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            mapper.Map(request, dataToUpdate, typeof(MyDataUpdateCommand), typeof(MyData));
            await myDataRepository.UpdateAsync(dataToUpdate);
            return Unit.Value;
        }
    }
}
