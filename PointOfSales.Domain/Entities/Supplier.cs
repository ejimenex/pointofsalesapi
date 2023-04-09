using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class Supplier:AuditableEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Commentary{get;set;}
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}
