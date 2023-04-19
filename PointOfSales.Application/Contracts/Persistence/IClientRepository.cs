namespace PointOfSales.Application.Contracts.Persistence
{
    public interface IClientRepository : IAsyncRepository<Client>
    {
        Task<List<Client>> GetPaged(string filter, int page, int size);
        Task<int> GetTotalCount(string filter);
        Task<bool> ExistPhoneNumber(string phoneNumber);
    }
}
