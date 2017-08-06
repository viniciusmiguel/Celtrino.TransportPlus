using Celtrino.TransportPlus.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Celtrino.TransportPlus.Web.ViewModels
{
    public class VehicleViewModel
    {
        public Guid Id { get; set; }
        public ICollection<MapPoint> LocationMapPoints { get; set; }
        public Guid IdModel { get; set; }
        public VehicleModel Model { get; set; }
        public string Plate { get; set; }
    }
}
