namespace PointOfSales.Application.Features.Client.Command.UpdateCommand
{
    public class UpdateClientCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public bool NotifyWhenInvoiced { get; set; }
        public string Commentary { get; set; }
    }
}
