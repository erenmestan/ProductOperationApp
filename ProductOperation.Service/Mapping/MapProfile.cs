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

            CreateMap<StandartStopping, StandartStoppingDto>()
                .ForMember(p => p.StartTime, o => o.MapFrom(src => src.StartDateTime.TimeOfDay))
                .ForMember(p => p.EndTime, o => o.MapFrom(src => src.EndDateTime.ToString("HH:mm")));
            CreateMap<StandartStoppingDto, StandartStopping>()
            .ForMember(p => p.StartDateTime, o => o.MapFrom(src => DateTime.Today + src.StartTime))
                .ForMember(p => p.EndDateTime, o => o.MapFrom(src => DateTime.Today + src.EndTime));

        }
    }
}
