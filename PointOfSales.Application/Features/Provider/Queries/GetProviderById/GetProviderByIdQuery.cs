namespace PointOfSales.Application.Features.Client.Queries.GetProviderById
{
    public class GetProviderByIdQuery : IRequest<GetProviderByIdVm>
    {
        public Guid Id { get; set; }
    }
}
