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
            CreateMap<NodeIndexViewModel, NodeListViewModel>();

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
                .ForMember(x => x.DiscordLink, opt => opt.MapFrom(x => x.SocialMedia.DiscordLink))
                .ForMember(x => x.GuideDescription, opt => opt.MapFrom(x => x.Guide.Description));

            CreateMap<NodeDetailsViewModel, NodeUpdateViewModel>()
                .ForPath(x => x.SocialMedia.TelegramLink, opt => opt.MapFrom(x => x.TelegramLink))
                .ForPath(x => x.SocialMedia.TwitterLink, opt => opt.MapFrom(x => x.TwitterLink))
                .ForPath(x => x.SocialMedia.DiscordLink, opt => opt.MapFrom(x => x.DiscordLink))
                .ForPath(x => x.SocialMedia.WebPageLink, opt => opt.MapFrom(x => x.WebPageLink))
                .ForPath(x => x.Hardware.CPU, opt => opt.MapFrom(x => x.HardwareCPU))
                .ForPath(x => x.Hardware.RAM, opt => opt.MapFrom(x => x.HardwareRAM))
                .ForPath(x => x.Hardware.Storage, opt => opt.MapFrom(x => x.HardwareStorage))
                .ForPath(x => x.Hardware.DownloadSpeed, opt => opt.MapFrom(x => x.HardwareDownloadSpeed))
                .ForPath(x => x.Review.Rate, opt => opt.MapFrom(x => x.ReviewRate))
                .ForPath(x => x.Review.Comment, opt => opt.MapFrom(x => x.ReviewComment))
                .ForPath(x => x.Review.Lock, opt => opt.MapFrom(x => x.ReviewLock))
                .ForPath(x => x.Review.Difficulty, opt => opt.MapFrom(x => x.ReviewDifficulty))
                .ForPath(x => x.Review.Prize, opt => opt.MapFrom(x => x.ReviewPrize))
                .ForPath(x => x.Guide.Description, opt => opt.MapFrom(x => x.GuideDescription));

            CreateMap<NodeCreateViewModel, PostNodeRequestModel>();
            CreateMap<NodeUpdateViewModel, PutNodeRequestModel>();
        }
    }
}
