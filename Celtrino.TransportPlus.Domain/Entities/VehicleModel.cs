using System;
using System.Collections.Generic;
using System.Text;

namespace Celtrino.TransportPlus.Domain.Entities
{
    public class VehicleModel
    {
        public Guid Id { get; set; }
        public Guid ManufacturerId { get; set; }
        public VehicleManufacturer Manufacturer { get; set; }
        public string Name { get; set; }
    }
}
