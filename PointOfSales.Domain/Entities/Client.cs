namespace PointOfSales.Domain.Entities
{
    public class Client : AuditableEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public bool NotifyWhenInvoiced { get; set; }
        public string Commentary { get; set; }
        public int OrdersQuantity { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
