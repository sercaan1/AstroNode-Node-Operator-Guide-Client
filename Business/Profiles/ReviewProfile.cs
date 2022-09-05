using AutoMapper;
using Common.Models.Integration.Reviews;
using Common.Models.ViewModels.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewCreateViewModel, PostReviewRequestModel>();
        }
    }
}
