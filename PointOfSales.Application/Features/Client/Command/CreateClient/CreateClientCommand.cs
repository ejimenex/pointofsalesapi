using MediatR;

namespace PointOfSales.Application.Features.Client.Command.CreateClient
{
    public class CreateClientCommand : IRequest<CreateClientCommandResponse>
    {
		public string Name { get; set; }=String.Empty;	
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public bool NotifyWhenInvoiced { get; set; }
		public string Commentary { get; set; }
	}
}
