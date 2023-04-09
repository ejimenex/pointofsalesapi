using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Command.UpdateProvider
{
    public class UpdateProviderCommandValidation : AbstractValidator<UpdateProviderCommand>
    {
        public UpdateProviderCommandValidation()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(p => p.Phone).NotEmpty().WithMessage("{PropertyName} is required").NotNull().MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters");
           
        }
    }
}
