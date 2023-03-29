using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class Orders:AuditableEntity
    {
		public Guid ClientId { get; set; }
		public Guid StatusId { get; set; }
		public string OrderNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime OrderPromisedDate { get; set; }
		public string Commentary { get; set; }
		public decimal TotalPaid { get; set; }
		public decimal Discount { get; set; }
		public decimal SubTotal { get; set; }
		public decimal Total { get; set; }
		public int OrdersQuantity { get; set; }
		public virtual Client Client { get; set; }	
		public virtual InternarParamOrderStatus InternarParamOrderStatus { get; set; }
		public ICollection<OrderDetail> OrderDetail { get; set; }
		public ICollection<OrderDetailHistoryPayments> OrderDetailHistoryPayments { get; set; }
	}
}
