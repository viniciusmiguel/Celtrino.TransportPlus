using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;
using Celtrino.TransportPlus.Domain.Interfaces.Services;

namespace Celtrino.TransportPlus.Domain.Services
{
    public class MapPointService : ServiceBase<MapPoint>, IMapPointService
    {
        private readonly IRepositoryBase<MapPoint> _repository;

        public MapPointService(IRepositoryBase<MapPoint> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
