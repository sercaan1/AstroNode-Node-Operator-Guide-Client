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
    public class NodeUpdateViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public HardwareUpdateViewModel Hardware { get; set; }
        public ReviewUpdateViewModel Review { get; set; }
        public SocialMediaUpdateViewModel SocialMedia { get; set; }
    }
}
