using PointOfSales.Application.Responses;

namespace PointOfSales.Application.Features.Client.Command.CreateClient
{
    public class CreateClientCommandResponse : BaseResponse
    {
        public CreateClientCommandResponse() : base() { }
        public CreateClientDto Client { get; set; } = default;
    }
}
