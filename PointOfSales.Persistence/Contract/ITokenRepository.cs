using PointOfSales.Application.Model;

namespace PointOfSales.Persistence.Contract
{
    public interface ITokenRepository
    {
        Task<TokenModel> GetTokenData();
        string GetEmail();
    }
}
