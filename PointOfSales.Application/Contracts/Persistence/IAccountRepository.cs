namespace PointOfSales.Application.Contracts.Persistence
{
    public interface IAccountRepository : IAsyncRepository<UserRegistrered>
    {
        Task<UserRegistrered> GetAvaliable(string email);
        Task<bool> ExistEmail(string email);
    }
}
