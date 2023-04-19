namespace PointOfSales.Domain.Entities
{
    public class InternarParamOrderStatus : BaseId
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<Orders> Order { get; set; }
    }
}
