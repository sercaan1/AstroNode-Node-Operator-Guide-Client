using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Integration.SocialMedias
{
    public class GetSocialMediaResponseModel
    {
        public string TwitterLink { get; set; }
        public string TelegramLink { get; set; }
        public string WebPageLink { get; set; }
        public string DiscordLink { get; set; }
        public string NodeId { get; set; }
    }
}
