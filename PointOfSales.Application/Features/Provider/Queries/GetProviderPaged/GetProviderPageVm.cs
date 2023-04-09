namespace PointOfSales.Application.Features.Client.Queries.GetProviderPaged
{
    public class GetProviderPageVm
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public List<ProviderPagedDto> Data { get; set; }
    }
}
