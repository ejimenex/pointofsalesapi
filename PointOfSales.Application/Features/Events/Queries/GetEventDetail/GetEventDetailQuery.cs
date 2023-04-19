namespace PointOfSales.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEvenDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
