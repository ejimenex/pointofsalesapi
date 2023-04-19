namespace PointOfSales.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(PointOfSalesDbContext dbContext) : base(dbContext)
        {

        }

        public Task<bool> IsEventNameAndUnique(string name)
        {
            var matches = _dbContext.Event.Any(c => c.Name.Equals(name));
            return Task.FromResult(matches);
        }
    }
}
