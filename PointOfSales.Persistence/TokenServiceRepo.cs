using Microsoft.AspNetCore.Http;
using PointOfSales.Application.Model;
using PointOfSales.Persistence.Contract;
using System.IdentityModel.Tokens.Jwt;

namespace PointOfSales.Persistence
{
    public class TokenRepo : ITokenRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        public TokenRepo(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public string GetEmail()
        {
            return GetTokenData().Result.Email;
        }

        public Task<TokenModel> GetTokenData()
        {
            var user = contextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            if (user is null)
                throw new ArgumentException("Header request is null");
            var tokenS = handler.ReadToken(user) as JwtSecurityToken;
            var userName = tokenS.Claims.ToList()[2];
            var tokenModel = new TokenModel
            {
                Email = userName.Value
            };
            return Task.FromResult(tokenModel);
        }

    }
}
