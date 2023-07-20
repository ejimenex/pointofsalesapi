namespace PointOfSales.Application.Contracts.Persistence
{
    public interface IServiceRepository : IAsyncRepository<Product>
    {
        Task<List<Product>> GetPaged(string filter, int page, int size);
        Task<int> GetTotalCount(string filter);
        Task<bool> ExistProduct(string name);
    }
}
