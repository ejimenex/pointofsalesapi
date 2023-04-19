namespace PointOfSales.Application.Features.Events.Queries.GetEventDetail
{
    public class GetQueryDetalEventHandler : IRequestHandler<GetEvenDetailQuery, EventDetailVm>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Event> eventRepository;
        private readonly IAsyncRepository<Category> categoryRepository;
        public GetQueryDetalEventHandler(IMapper mapper, IAsyncRepository<Event> asyncRepository, IAsyncRepository<Category> categoryRepository)
        {
            this.mapper = mapper;
            this.categoryRepository = categoryRepository;
            eventRepository = asyncRepository;

        }
        public async Task<EventDetailVm> Handle(GetEvenDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await eventRepository.GetByIdAsync(request.Id);
            var detail = mapper.Map<EventDetailVm>(@event);
            var category = await categoryRepository.GetByIdAsync(@event.CategoryId);
            detail.Category = mapper.Map<CategoryDto>(category);
            return detail;
        }


    }
}
