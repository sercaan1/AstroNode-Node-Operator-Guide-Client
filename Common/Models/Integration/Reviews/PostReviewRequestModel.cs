using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Integration.Reviews
{
    public class PostReviewRequestModel
    {
        public string Comment { get; set; }
        public int? Rate { get; set; }
        public int? Difficulty { get; set; }
        public string Prize { get; set; }
        public string Lock { get; set; }
        public string NodeId { get; set; }
    }
}
