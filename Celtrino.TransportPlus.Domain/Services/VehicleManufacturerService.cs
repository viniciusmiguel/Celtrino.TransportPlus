using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;
using Celtrino.TransportPlus.Domain.Interfaces.Services;

namespace Celtrino.TransportPlus.Domain.Services
{
    public class VehicleManufacturerService : ServiceBase<VehicleManufacturer>, IVehicleManufacturerService
    {
        private readonly IRepositoryBase<VehicleManufacturer> _repository;

        public VehicleManufacturerService(IRepositoryBase<VehicleManufacturer> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
