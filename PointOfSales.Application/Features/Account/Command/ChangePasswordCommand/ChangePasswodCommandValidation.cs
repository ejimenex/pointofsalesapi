using FluentValidation;

namespace PointOfSales.Application.Features.Account.Command.ChangePasswordCommand

{
    public class ChangePasswodCommandValidation : AbstractValidator<ChangePasswordAccountCommand>
    {
        public ChangePasswodCommandValidation()
        {
            RuleFor(p => p.OldPassword).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.NewPassword).NotEmpty().WithMessage("{PropertyName} is required").NotNull()
                .MinimumLength(8).WithMessage("{PropertyName} need to have more than 8 characters")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");

        }
    }
}


