using Celtrino.TransportPlus.App.Interfaces;
using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.App
{
    public class VehicleManufacturerAppService : AppServiceBase<VehicleManufacturer>, IVehicleManufacturerAppService
    {
        public VehicleManufacturerAppService(IServiceBase<VehicleManufacturer> servicebase) : base(servicebase)
        {
        }
    }
}
