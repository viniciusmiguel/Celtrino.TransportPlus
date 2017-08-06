using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Celtrino.TransportPlus.Domain.Entities
{
    public class VehicleManufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<VehicleModel> Models { get; set; }
    }
}
