namespace PointOfSales.Application.Features.Login.Query.GetExistingUser
{
    public class LoginQuery : IRequest<TokenResult>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
