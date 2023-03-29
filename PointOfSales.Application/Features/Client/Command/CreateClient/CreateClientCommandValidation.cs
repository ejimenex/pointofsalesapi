using FluentValidation;

namespace PointOfSales.Application.Features.Client.Command.CreateClient
{
    public class CreateClientCommandValidation : AbstractValidator<CreateClientCommand>
    {
        private readonly IClientRepository clientRepository;
        public CreateClientCommandValidation(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters");
            RuleFor(c => c).MustAsync(ValidateUniquePhone).WithMessage("This phone already exist");
        }
        private async Task<bool> ValidateUniquePhone(CreateClientCommand e, CancellationToken token)
        {
            return (!await this.clientRepository.ExistPhoneNumber(e.Phone));
        }
    }
}
