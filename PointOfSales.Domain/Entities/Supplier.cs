namespace PointOfSales.Domain.Entities
{
    public class Supplier : AuditableEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}
