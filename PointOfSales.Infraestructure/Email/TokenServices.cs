using System.IdentityModel.Tokens.Jwt;
using PointOfSales.Application.Infraestructure;
using PointOfSales.Application.Model;
using Microsoft.AspNetCore.Http;

namespace PointOfSales.Infraestructure.Email
{
    public class TokenServices : ITokenService
    {
        private readonly IHttpContextAccessor contextAccessor;
        public TokenServices( IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }
        public Task<TokenModel> GetTokenData()
        {
           var user = contextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault().Replace("Bearer ","");
            var handler = new JwtSecurityTokenHandler();
            if (user is null)
                throw new ArgumentException("Header request is null");
            var jsonToken = handler.ReadToken(user);
            var tokenS = handler.ReadToken(user) as JwtSecurityToken;
           var userName = tokenS.Claims.ToList()[2];
            var tokenModel=new TokenModel{
                Email=userName.Value
            };
            return Task.FromResult(tokenModel);
        }
    
    }
}
