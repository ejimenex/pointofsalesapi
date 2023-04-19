namespace PointOfSales.Application.Features.Client.Command.CreateProvider
{
    public class CreateProviderDto
    {
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Commentary { get; set; }
    }
}
