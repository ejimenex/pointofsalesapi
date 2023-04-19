namespace PointOfSales.Domain.Common
{
    public class AuditableEntity : BaseId
    {
        public bool IsDeleted { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
