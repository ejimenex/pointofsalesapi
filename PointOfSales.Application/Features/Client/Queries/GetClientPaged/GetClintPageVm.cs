namespace PointOfSales.Application.Features.Client.Queries.GetClientPaged
{
    public class GetClintPageVm
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public List<ClientPagedDto> Data { get; set; }
    }
}
