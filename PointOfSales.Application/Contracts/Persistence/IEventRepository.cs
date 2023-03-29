using PointOfSales.Domain.Entities;

namespace PointOfSales.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndUnique(string name);
    }
}
