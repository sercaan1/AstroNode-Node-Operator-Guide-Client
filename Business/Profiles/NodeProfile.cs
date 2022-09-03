using AutoMapper;
using Common.Models.Integration.Nodes;
using Common.Models.ViewModels.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class NodeProfile : Profile
    {
        public NodeProfile()
        {
            CreateMap<GetNodeResponseModel, NodeIndexViewModel>()
                .ForMember(x => x.HardwareCPU, opt => opt.MapFrom(src => src.Hardware.Cpu))
                .ForMember(x => x.HardwareDownloadSpeed, opt => opt.MapFrom(src => src.Hardware.DownloadSpeed))
                .ForMember(x => x.HardwareRAM, opt => opt.MapFrom(src => src.Hardware.Ram))
                .ForMember(x => x.HardwareStorage, opt => opt.MapFrom(src => src.Hardware.Storage))
                .ForMember(x => x.TwitterLink, opt => opt.MapFrom(src => src.SocialMedia.TwitterLink))
                .ForMember(x => x.TelegramLink, opt => opt.MapFrom(src => src.SocialMedia.TelegramLink))
                .ForMember(x => x.DiscordLink, opt => opt.MapFrom(src => src.SocialMedia.DiscordLink))
                .ForMember(x => x.WebPageLink, opt => opt.MapFrom(src => src.SocialMedia.WebPageLink));
        }
    }
}
