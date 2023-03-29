using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Login.Query.GetExistingUser
{
    public class ExistinUserValidation : AbstractValidator<LoginQuery>
    {
        private readonly IAccountRepository accountRepository;
        public ExistinUserValidation(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
            RuleFor(p => p.UserName).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Password).NotEmpty().WithMessage("{PropertyName} is required").NotNull()
                .MinimumLength(8).WithMessage("{PropertyName} need to have more than 8 characters")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(c => c).MustAsync(ValidateUser).WithMessage("This user does not exist");
            RuleFor(c => c.UserName).EmailAddress().WithMessage("{PropertyValue} is not valid email");
        }
        private async Task<bool> ValidateUser(LoginQuery e, CancellationToken token)
        {
            var exist= (await this.accountRepository.GetAvaliable(e.UserName));
            return exist is not null;
        }
    }
}


