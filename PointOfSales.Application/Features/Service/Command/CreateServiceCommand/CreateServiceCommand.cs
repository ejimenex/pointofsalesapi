namespace PointOfSales.Application.Features.Service.Command.CreateService
{
    public class CreateServiceCommand : IRequest<CreateServiceCommandResponse>
    {
        public string Name { get; set; } = String.Empty;
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public bool NotifyWhenInvoiced { get; set; }
        public string Commentary { get; set; }
    }
}
