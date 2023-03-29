using MediatR;
using PointOfSales.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Command.UpdateCommand
{
    public class UpdateClientCommandHandler:IRequestHandler<UpdateClientCommand>
    {
        private readonly IClientRepository clientRepository;
        private readonly IMapper _mapper;
        public UpdateClientCommandHandler(IClientRepository clientRepository, IMapper mapper)
        {
            this.clientRepository = clientRepository;
            this._mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateClientCommandValidation();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                var errors = string.Join(',',validationResult.Errors);
                throw new BadRequestException(errors);
            }
            var clientToUpdate = await clientRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, clientToUpdate, typeof(UpdateClientCommand), typeof(Event));
            await clientRepository.UpdateAsync(clientToUpdate);
            return Unit.Value;
        }
    }
}
