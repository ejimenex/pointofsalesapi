using PointOfSales.Domain.Entities;

namespace PointOfSales.Application.Contracts.Persistence
{
    internal interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
