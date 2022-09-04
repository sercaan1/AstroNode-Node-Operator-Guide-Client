using Common.Models.Integration.Hardwares;
using Common.Models.Integration.SocialMedias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Integration.Nodes
{
    public class GetNodeListResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ReviewRate { get; set; }
        public int? ReviewDifficulty { get; set; }
    }
}
