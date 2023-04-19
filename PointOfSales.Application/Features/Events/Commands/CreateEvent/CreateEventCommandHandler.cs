using PointOfSales.Application.Infraestructure;
using PointOfSales.Application.Model;

namespace PointOfSales.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository eventRepository;
        private readonly IEmailService mailService;
        public CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository, IEmailService mailService)
        {
            this._mapper = mapper;
            this.eventRepository = eventRepository;
            this.mailService = mailService;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<Event>(request);
            var validator = new EventCommandValidation(eventRepository);
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {

                throw new Exceptions.ValidationException(validationResult);
            }



            @event = await eventRepository.AddAsync(@event);
       
            return @event.EventId;
        }
    }
}
