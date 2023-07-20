using FluentValidation;

namespace PointOfSales.Application.Features.Service.Command.CreateService
{
    public class CreateServiceCommandValidation : AbstractValidator<CreateServiceCommand>
    {
        private readonly IServiceRepository clientRepository;
        public CreateServiceCommandValidation(IServiceRepository clientRepository)
        {
            this.clientRepository = clientRepository;
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Price).NotNull().WithMessage("{PropertyName} is required");
            RuleFor(c => c).MustAsync(ValidateUniqueProduct).WithMessage("This product already exist");
        }
        private async Task<bool> ValidateUniqueProduct(CreateServiceCommand e, CancellationToken token)
        {
            return (!await this.clientRepository.ExistProduct(e.Name));
        }
    }
}
