using AutoMapper;
using SignalR.DTOLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About,ResultAboutDto>().ReverseMap(); 
            CreateMap<About,GetAboutDto>().ReverseMap(); 
            CreateMap<About,UpdateAboutDto>().ReverseMap(); 
            CreateMap<About,CreateAboutDto>().ReverseMap(); 
        }
    }


}
