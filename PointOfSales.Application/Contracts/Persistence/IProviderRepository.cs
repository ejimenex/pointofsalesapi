using PointOfSales.Domain.Entities;

namespace PointOfSales.Application.Contracts.Persistence
{
    public interface IProviderRepository : IAsyncRepository<Supplier>
    {
        Task<List<Supplier>> GetPaged(string filter, int page, int size);
        Task<int> GetTotalCount(string filter);
        Task<bool> ExistPhoneNumber(string phoneNumber);
    }
}
