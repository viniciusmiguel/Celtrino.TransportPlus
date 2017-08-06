using Celtrino.TransportPlus.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Celtrino.TransportPlus.Web.ViewModels
{
    public class VehicleManufacturerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<VehicleModel> Models { get; set; }
    }
}
