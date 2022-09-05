using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Integration.Hardwares
{
    public class PostHardwareRequestModel
    {
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string DownloadSpeed { get; set; }
        public string NodeId { get; set; }
    }
}
