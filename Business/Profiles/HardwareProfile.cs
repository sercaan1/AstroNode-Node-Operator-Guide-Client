using AutoMapper;
using Common.Models.Integration.Hardwares;
using Common.Models.ViewModels.Hardwares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class HardwareProfile : Profile
    {
        public HardwareProfile()
        {
            CreateMap<HardwareCreateViewModel, PostHardwareRequestModel>();
        }
    }
}
