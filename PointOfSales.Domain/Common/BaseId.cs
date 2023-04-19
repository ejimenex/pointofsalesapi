using System.ComponentModel.DataAnnotations;

namespace PointOfSales.Domain.Common
{

    public class BaseId
    {
        [Key]
        public Guid Id { get; set; }
    }
}
