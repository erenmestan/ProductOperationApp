using AutoMapper;
using ProductOperation.Core.DTOs;
using ProductOperation.Core.Models;

namespace ProductOperation.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProductionOperation, ProductionOperationDTO>().ReverseMap();
            CreateMap<StandartStopping, StandartStoppingDto>().ReverseMap();
        }
    }
}
