namespace PointOfSales.Application.Features.Client.Queries.GetClientPaged
{
    public class ClientPagedDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public bool NotifyWhenInvoiced { get; set; }
        public string Commentary { get; set; }
        public int OrdersQuantity { get; set; }
    }
}
