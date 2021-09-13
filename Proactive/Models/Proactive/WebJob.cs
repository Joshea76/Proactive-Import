using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class WebJob
    {
        public int WebJobId { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public DateTime LastRunDate { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
