using FluentValidation;

namespace PointOfSales.Application.Features.Client.Command.UpdateCommand
{
    public class UpdateClientCommandValidation : AbstractValidator<UpdateClientCommand>
    {
        public UpdateClientCommandValidation()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters");

        }
    }
}
