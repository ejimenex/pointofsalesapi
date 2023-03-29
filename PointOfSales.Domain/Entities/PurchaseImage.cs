﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Domain.Entities
{
    public class PurchaseImage:AuditableEntity
    {
        public Guid PurchaseId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
