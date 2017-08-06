using Celtrino.TransportPlus.Domain.Entities;
using System;

namespace Celtrino.TransportPlus.Web.ViewModels
{
    public class VehicleModelViewModel
    {
        public Guid Id { get; set; }
        public Guid ManufacturerId { get; set; }
        public VehicleManufacturer Manufacturer { get; set; }
        public string Name { get; set; }
    }
}
