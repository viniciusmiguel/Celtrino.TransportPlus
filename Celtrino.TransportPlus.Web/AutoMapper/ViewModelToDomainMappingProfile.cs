using AutoMapper;
using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Web.ViewModels;

namespace Celtrino.TransportPlus.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MapPointViewModel, MapPoint>();
            CreateMap<VehicleViewModel, Vehicle>();
            CreateMap<VehicleManufacturerViewModel, VehicleManufacturer>();
            CreateMap<VehicleModelViewModel, VehicleModel>();
        }
    }
}
