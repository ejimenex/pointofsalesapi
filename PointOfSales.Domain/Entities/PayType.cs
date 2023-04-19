namespace PointOfSales.Domain.Entities
{
    public class PayType : BaseId
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<OrderDetailHistoryPayments> OrderDetailHistoryPayments { get; set; }
    }
}
