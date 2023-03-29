using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class InternalParamCurrency:BaseId
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
