using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.ViewModels.Hardwares
{
    public class HardwareCreateViewModel
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string DownloadSpeed { get; set; }
    }
}
