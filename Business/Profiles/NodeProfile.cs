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
            CreateMap<GetNodeListResponseModel, NodeIndexViewModel>();

            CreateMap<GetNodeDetailsReponseModel, NodeDetailsViewModel>()
                .ForMember(x => x.ReviewRate, opt => opt.MapFrom(x => x.Review.Rate))
                .ForMember(x => x.ReviewDifficulty, opt => opt.MapFrom(x => x.Review.Difficulty))
                .ForMember(x => x.ReviewPrize, opt => opt.MapFrom(x => x.Review.Prize))
                .ForMember(x => x.ReviewLock, opt => opt.MapFrom(x => x.Review.Lock))
                .ForMember(x => x.ReviewComment, opt => opt.MapFrom(x => x.Review.Comment))
                .ForMember(x => x.HardwareCPU, opt => opt.MapFrom(x => x.Hardware.Cpu))
                .ForMember(x => x.HardwareRAM, opt => opt.MapFrom(x => x.Hardware.Ram))
                .ForMember(x => x.HardwareStorage, opt => opt.MapFrom(x => x.Hardware.Storage))
                .ForMember(x => x.HardwareDownloadSpeed, opt => opt.MapFrom(x => x.Hardware.DownloadSpeed))
                .ForMember(x => x.TwitterLink, opt => opt.MapFrom(x => x.SocialMedia.TwitterLink))
                .ForMember(x => x.TelegramLink, opt => opt.MapFrom(x => x.SocialMedia.TelegramLink))
                .ForMember(x => x.WebPageLink, opt => opt.MapFrom(x => x.SocialMedia.WebPageLink))
                .ForMember(x => x.DiscordLink, opt => opt.MapFrom(x => x.SocialMedia.DiscordLink));

            CreateMap<NodeCreateViewModel, PostNodeRequestModel>();
        }
    }
}
