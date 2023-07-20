using PointOfSales.Application.Features.Client.Command.CreateClient;
using PointOfSales.Application.Features.Service.Command.CreateServiceCommand;
using PointOfSales.Application.Responses;

namespace PointOfSales.Application.Features.Service.Command.CreateService
{
    public class CreateServiceCommandResponse : BaseResponse
    {
        public CreateServiceCommandResponse() : base() { }
        public CreateServiceDto Product { get; set; } = default;
    }
}
