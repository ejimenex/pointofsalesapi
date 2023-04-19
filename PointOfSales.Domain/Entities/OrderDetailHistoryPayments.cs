namespace PointOfSales.Domain.Entities
{
    public class OrderDetailHistoryPayments : AuditableEntity
    {
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public Guid PaymentTypeId { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual PayType PayType { get; set; }
    }
}
