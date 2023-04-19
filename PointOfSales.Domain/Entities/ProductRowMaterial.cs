namespace PointOfSales.Domain.Entities
{
    public class ProductRowMaterial : AuditableEntity
    {
        public Guid ProductId { get; set; }
        public Guid RawMateria { get; set; }
        public virtual RawMaterial RawMaterial { get; set; }
        public virtual Product Product { get; set; }
        public decimal Quantity { get; set; }
    }
}
