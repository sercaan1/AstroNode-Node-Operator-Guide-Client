using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.ViewModels.Nodes
{
    public class NodeIndexViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string HardwareCPU { get; set; }
        public string HardwareRAM { get; set; }
        public string HardwareStorage { get; set; }
        public string HardwareDownloadSpeed { get; set; }
        public string TwitterLink { get; set; }
        public string TelegramLink { get; set; }
        public string DiscordLink { get; set; }
        public string WebPageLink { get; set; }
    }
}
