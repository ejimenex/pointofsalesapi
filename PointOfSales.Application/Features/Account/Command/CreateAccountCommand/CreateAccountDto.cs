namespace PointOfSales.Application.Features.Account.Command.CreateAccountCommand
{
    public class CreateAccountDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public Guid? CountryId { get; set; }
        public string Password { get; set; }
        public string Language { get; set; }
    }
}
