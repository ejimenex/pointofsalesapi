namespace PointOfSales.Domain.Entities
{
    public class OrderDetail : AuditableEntity
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public virtual Product Product { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
