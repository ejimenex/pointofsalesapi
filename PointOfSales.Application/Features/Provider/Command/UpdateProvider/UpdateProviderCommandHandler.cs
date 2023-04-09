using MediatR;
using PointOfSales.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Command.UpdateProvider
{
    public class UpdateProviderCommandHandler:IRequestHandler<UpdateProviderCommand>
    {
        private readonly IProviderRepository providerRepository;
        private readonly IMapper _mapper;
        public UpdateProviderCommandHandler(IProviderRepository providerRepository, IMapper mapper)
        {
            this.providerRepository = providerRepository;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProviderCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProviderCommandValidation();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                var errors = string.Join(',',validationResult.Errors);
                throw new BadRequestException(errors);
            }
            var providerToUpdate = await providerRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, providerToUpdate, typeof(UpdateProviderCommand), typeof(Event));
            await providerRepository.UpdateAsync(providerToUpdate);
            return Unit.Value;
        }
    }
}
