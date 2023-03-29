using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Account.Command.CreateAccountCommand
{
    public class CreateAccountCommandValidation : AbstractValidator<CreateAccountCommand>
    {
        private readonly IAccountRepository accountRepository;
        public CreateAccountCommandValidation(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Email).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 20 characters");
            RuleFor(p => p.Password).NotEmpty().WithMessage("{PropertyName} is required").NotNull()
                .MinimumLength(8).WithMessage("{PropertyName} need to have more than 8 characters")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(c => c).MustAsync(ValidateUniqueEmail).WithMessage("This email already exist");
            RuleFor(c => c.Language).NotEmpty().NotNull().WithMessage("{PropertyName} is required");
            RuleFor(c => c.Email).EmailAddress().WithMessage("{PropertyValue} is not valid email");
        }
        private async Task<bool> ValidateUniqueEmail(CreateAccountCommand e, CancellationToken token)
        {
            return (!await this.accountRepository.ExistEmail(e.Email));
        }
    }
}


