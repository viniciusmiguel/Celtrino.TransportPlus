using Celtrino.TransportPlus.App.Interfaces;
using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.App
{
    public class VehicleAppService : AppServiceBase<Vehicle> , IVehicleAppService
    {
        public VehicleAppService(IServiceBase<Vehicle> servicebase) : base(servicebase)
        {
        }
    }
}
