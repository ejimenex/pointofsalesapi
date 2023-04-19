namespace PointOfSales.Domain.Entities
{
    public class Purchase : AuditableEntity
    {
        public Guid SupplierId { get; set; }
        public string Concept { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Commentary { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseImage> PurchaseImage { get; set; }
    }
}
