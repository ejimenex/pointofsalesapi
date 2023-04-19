using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.MyDataCrud.Command.UpdateCommand
{
    public class UpdateMyDataValidator:AbstractValidator<MyDataUpdateCommand>
    {
        public UpdateMyDataValidator()
        {
            RuleFor(p => p.InvoicePrefix).NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(p => p.OrderPrefix).NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(p => p.CompanyName).NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
