namespace PointOfSales.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public bool IsService { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal Cost { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public bool IsInventoriable { get; set; }
        public decimal MinimalStock { get; set; }
        public decimal Stock { get; set; }
        public string PhotoUrl { get; set; }
        public string Commentary { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
