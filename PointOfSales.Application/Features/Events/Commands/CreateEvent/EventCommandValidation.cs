using FluentValidation;

namespace PointOfSales.Application.Features.Events.Commands.CreateEvent
{
    public class EventCommandValidation : AbstractValidator<CreateEventCommand>
    {
        private readonly IEventRepository eventRepository;
        public EventCommandValidation(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Date).NotNull().WithMessage("{PropertyName} is required").NotNull().GreaterThan(DateTime.Now);
            RuleFor(p => p.Price).NotEmpty().WithMessage("{PropertyName} is required").GreaterThan(0);
            RuleFor(c => c).MustAsync(ValidateUniqueName).WithMessage("This event already exist");

        }
        private async Task<bool> ValidateUniqueName(CreateEventCommand e, CancellationToken token)
        {
            return (!await this.eventRepository.IsEventNameAndUnique(e.Name));
        }
    }
}
