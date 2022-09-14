using Common.Models.Integration.Guides;
using Common.Models.Integration.Hardwares;
using Common.Models.Integration.Reviews;
using Common.Models.Integration.SocialMedias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Integration.Nodes
{
    public class PostNodeRequestModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PostHardwareRequestModel Hardware {get; set;}
        public PostReviewRequestModel Review {get; set;}
        public PostSocialMediaRequestModel SocialMedia { get; set; }
        public PostGuideRequestModel Guide { get; set; }
    }
}
