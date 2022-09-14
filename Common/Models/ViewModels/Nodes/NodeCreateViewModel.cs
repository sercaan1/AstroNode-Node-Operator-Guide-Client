using Common.Models.ViewModels.Guides;
using Common.Models.ViewModels.Hardwares;
using Common.Models.ViewModels.Reviews;
using Common.Models.ViewModels.SocialMedias;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.ViewModels.Nodes
{
    public class NodeCreateViewModel
    {
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HardwareCreateViewModel Hardware { get; set; }
        public ReviewCreateViewModel Review { get; set; }
        public SocialMediaCreateViewModel SocialMedia { get; set; }
        public GuideCreateViewModel Guide { get; set; }
    }
}
