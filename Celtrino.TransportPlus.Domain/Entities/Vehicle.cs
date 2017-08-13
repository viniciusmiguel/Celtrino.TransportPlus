using System;
using System.Collections.Generic;
using System.Text;

namespace Celtrino.TransportPlus.Domain.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public ICollection<MapPoint> LocationMapPoints { get; set; }
        public Guid IdModel { get; set; }
        public VehicleModel Model { get; set; }
        public string Plate { get; set; }
        public string SIMCardNumber { get; set; }
    }
}
