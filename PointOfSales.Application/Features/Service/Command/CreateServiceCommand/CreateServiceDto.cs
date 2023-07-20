using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.Service.Command.CreateServiceCommand
{
    public class CreateServiceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsService { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal Cost { get; set; }
        public decimal? Price { get; set; }
        public string Currency { get; set; }
        public bool IsInventoriable { get; set; }
        public decimal MinimalStock { get; set; }
        public decimal Stock { get; set; }
        public string PhotoUrl { get; set; }
        public string Commentary { get; set; }
    }
}
