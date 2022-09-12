using AutoMapper;
using Common.Models.Integration.Users;
using Common.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<LoginViewModel, PostLoginRequestModel>();
        }
    }
}
