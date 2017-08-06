using Celtrino.TransportPlus.Domain.Entities;
using System;

namespace Celtrino.TransportPlus.Web.ViewModels
{
    public class MapPointViewModel
    {
        public Guid Id { get; set; }
        public Guid IdVehicle { get; set; }
        public Vehicle Vehicle { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
