using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class PayType:BaseId
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<OrderDetailHistoryPayments> OrderDetailHistoryPayments { get; set; }
    }
}
