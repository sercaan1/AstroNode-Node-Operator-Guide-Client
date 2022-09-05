using AutoMapper;
using Common.Models.Integration.SocialMedias;
using Common.Models.ViewModels.SocialMedias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SocialMediaProfile : Profile
    {
        public SocialMediaProfile()
        {
            CreateMap<SocialMediaCreateViewModel, PostSocialMediaRequestModel>();
            CreateMap<SocialMediaUpdateViewModel, PutSocialMediaRequestModel>();
        }
    }
}
