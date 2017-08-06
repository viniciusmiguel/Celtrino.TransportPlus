using System;

namespace Celtrino.TransportPlus.Domain.Entities
{
    public class MapPoint
    {
        public Guid Id { get; set; }
        public Guid IdVehicle { get; set; }
        public Vehicle Vehicle { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
