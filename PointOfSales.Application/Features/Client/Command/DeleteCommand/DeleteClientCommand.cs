namespace PointOfSales.Application.Features.Client.Command.DeleteCommand
{
    public class DeleteClientCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
