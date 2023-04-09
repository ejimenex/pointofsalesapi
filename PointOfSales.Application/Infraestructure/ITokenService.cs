using PointOfSales.Application.Model;

namespace PointOfSales.Application.Infraestructure
{
    public interface ITokenService
    {
        Task<TokenModel> GetTokenData();
    }
}
