using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class MyData:AuditableEntity
    {
		public string CompanyRegistrationNumber { get; set; }
		public string CompanyName { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyPhone { get; set; }
		public string CompanyEmail { get; set; }
		public string InvoicePrefix { get; set; }
		public int InvoiceSecuence { get; set; }
		public string OrderPrefix { get; set; }
		public int OrderSecuence { get; set; }
		public string Currency { get; set; }
		public string InvoiceTextFooter { get; set; }
	}
}
