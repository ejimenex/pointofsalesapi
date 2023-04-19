namespace PointOfSales.Application.Features.Client.Queries.GetClientById
{
    public class GetClientByIdQuery : IRequest<GetClientByIdVm>
    {
        public Guid Id { get; set; }
    }
}
