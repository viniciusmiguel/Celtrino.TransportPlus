using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;
using Celtrino.TransportPlus.Domain.Interfaces.Services;

namespace Celtrino.TransportPlus.Domain.Services
{
    public class VehicleService : ServiceBase<Vehicle>, IVehicleService
    {
        private readonly IRepositoryBase<Vehicle> _repository;

        public VehicleService(IRepositoryBase<Vehicle> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
