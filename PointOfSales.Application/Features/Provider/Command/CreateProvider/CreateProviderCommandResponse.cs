using PointOfSales.Application.Responses;

namespace PointOfSales.Application.Features.Client.Command.CreateProvider
{
    public class CreateProviderCommandResponse : BaseResponse
    {
        public CreateProviderCommandResponse() : base() { }
        public CreateProviderDto Client { get; set; } = default;
    }
}
