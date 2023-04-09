using MediatR;

namespace PointOfSales.Application.Features.Client.Queries.GetProviderPaged
{
    public class GetProviderPagedQuery : IRequest<GetProviderPageVm>
    {
        public string? Filter { get; set; }=string.Empty;
        public int Page { get; set; } = 1;
        public int Size { get; set; } = 10;
    }
}
