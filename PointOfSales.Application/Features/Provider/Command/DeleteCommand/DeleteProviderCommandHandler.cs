namespace PointOfSales.Application.Features.Client.Command.DeleteProviderCommand
{
    public class DeleteProviderCommandHandler : IRequestHandler<DeleteProviderCommand>
    {
        private readonly IProviderRepository providerRepository;
        public DeleteProviderCommandHandler(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;

        }

        public async Task<Unit> Handle(DeleteProviderCommand request, CancellationToken cancellationToken)
        {
            var providerToDelete = await providerRepository.GetByIdAsync(request.Id);
            providerToDelete.IsDeleted = true;
            await providerRepository.UpdateAsync(providerToDelete);
            return Unit.Value;
        }
    }
}
