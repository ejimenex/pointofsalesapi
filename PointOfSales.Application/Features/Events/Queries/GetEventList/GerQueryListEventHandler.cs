namespace PointOfSales.Application.Features.Events.Queries.GetEventList
{
    public class GerQueryListEventHandler : IRequestHandler<GetEventListQuery, List<EventListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Event> eventRepository;
        public GerQueryListEventHandler(IMapper mapper, IAsyncRepository<Event> asyncRepository)
        {
            this.mapper = mapper;
            eventRepository = asyncRepository;

        }
        public async Task<List<EventListVm>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            var allEvent = (await eventRepository.ListAllAsync()).OrderBy(c => c.Date);
            return mapper.Map<List<EventListVm>>(allEvent);
        }
    }
}
