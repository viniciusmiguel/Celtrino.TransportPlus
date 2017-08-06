using Celtrino.TransportPlus.App.Interfaces;
using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.App
{
    public class VehicleModelAppService : AppServiceBase<VehicleModel>, IVehicleModelAppService
    {
        public VehicleModelAppService(IServiceBase<VehicleModel> servicebase) : base(servicebase)
        {
        }
    }
}
