using AutoMapper;
using Celtrino.TransportPlus.Domain.Entities;
using Celtrino.TransportPlus.Web.ViewModels;

namespace Celtrino.TransportPlus.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<MapPoint , MapPointViewModel>();
            CreateMap<Vehicle , VehicleViewModel>();
            CreateMap<VehicleManufacturer , VehicleManufacturerViewModel>();
            CreateMap<VehicleModel , VehicleModelViewModel>();
        }
    }
}
