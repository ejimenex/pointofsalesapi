using FluentValidation;

namespace PointOfSales.Application.Features.Client.Command.CreateProvider
{
    public class CreateProviderCommandValidation : AbstractValidator<CreateProviderCommand>
    {
        private readonly IProviderRepository providerRepository;
        public CreateProviderCommandValidation(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters");
            RuleFor(c => c).MustAsync(ValidateUniquePhone).WithMessage("This phone already exist");
        }
        private async Task<bool> ValidateUniquePhone(CreateProviderCommand e, CancellationToken token)
        {
            return (!await this.providerRepository.ExistPhoneNumber(e.Phone));
        }
    }
}
