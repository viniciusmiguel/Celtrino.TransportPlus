using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;
using Celtrino.TransportPlus.Domain.Interfaces.Services;

namespace Celtrino.TransportPlus.Domain.Services
{
    public class VehicleModelService : ServiceBase<VehicleModel>, IVehicleModelService
    {
        private readonly IRepositoryBase<VehicleModel> _repository;

        public VehicleModelService(IRepositoryBase<VehicleModel> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
