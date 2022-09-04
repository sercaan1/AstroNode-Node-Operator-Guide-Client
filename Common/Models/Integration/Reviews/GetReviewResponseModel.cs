using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Integration.Reviews
{
    public class GetReviewResponseModel
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        public int? Rate { get; set; }
        public int? Difficulty { get; set; }
        public string Prize { get; set; }
        public string Lock { get; set; }
        public Guid NodeId { get; set; }
    }
}
