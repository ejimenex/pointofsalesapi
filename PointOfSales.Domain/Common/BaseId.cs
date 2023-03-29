using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Common
{

    public class BaseId
    {
        [Key]
        public Guid Id { get; set; }
    }
}
