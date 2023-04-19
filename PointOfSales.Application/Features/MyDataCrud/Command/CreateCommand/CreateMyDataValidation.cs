using FluentValidation;

namespace PointOfSales.Application.Features.MyDataCrud.Command.CreateCommand
{
    public class CreateMyDataValidation : AbstractValidator<CreateMyDataCommand>
    {
        public CreateMyDataValidation()
        {
            RuleFor(p => p.InvoicePrefix).NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(p => p.InvoiceSecuence).NotEmpty().NotEqual(0).WithMessage("{PropertyName} is required");
            RuleFor(p => p.OrderPrefix).NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(p => p.CompanyName).NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(p => p.OrderSecuence).NotEmpty().NotEqual(0).WithMessage("{PropertyName} is required");
        }
    }
}
