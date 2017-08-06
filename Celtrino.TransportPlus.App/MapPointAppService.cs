using Celtrino.TransportPlus.App.Interfaces;
using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Domain.Interfaces;
using Celtrino.TransportPlus.Domain.Services;

namespace Celtrino.TransportPlus.App
{
    public class MapPointAppService : ServiceBase<MapPoint>, IMapPointAppService
    {
        public MapPointAppService(IRepositoryBase<MapPoint> repository) : base(repository)
        {

        }
    }
}
