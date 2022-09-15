using AutoMapper;
using Common.Models.Integration.Guides;
using Common.Models.ViewModels.Guides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class GuideProfile : Profile
    {
        public GuideProfile()
        {
            CreateMap<GuideCreateViewModel, PostGuideRequestModel>();
            CreateMap<GuideUpdateViewModel, PutGuideRequestModel>();
        }
    }
}
