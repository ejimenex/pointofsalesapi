namespace PointOfSales.Application.Features.Client.Command.DeleteProviderCommand
{
    public class DeleteProviderCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
