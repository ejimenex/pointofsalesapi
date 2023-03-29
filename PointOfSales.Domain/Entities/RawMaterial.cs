using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class RawMaterial:AuditableEntity
    {

		public string Name { get; set; }
		public string UnitOfMeasureCode { get; set; }
		public decimal Price { get; set; }
		public string Currency { get; set; }
		public decimal? Stock { get; set; }
		public decimal MinimalStock { get; set; }
		public string Commentary { get; set; }
	}
}
