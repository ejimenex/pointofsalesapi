using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Client.Command.DeleteCommand
{
    public class DeleteClientCommandHandler:IRequestHandler<DeleteClientCommand>
    {
        private readonly IClientRepository clientRepository;
        public DeleteClientCommandHandler(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;

        }

        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var clientToDelete = await clientRepository.GetByIdAsync(request.Id);
            clientToDelete.IsDeleted = true;
            await clientRepository.UpdateAsync(clientToDelete);
            return Unit.Value;
        }
    }
}
