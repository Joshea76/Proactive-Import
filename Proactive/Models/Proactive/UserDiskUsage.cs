using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class UserDiskUsage
    {
        public int UserDiskUsageId { get; set; }
        public string UserId { get; set; }
        public long BytesUsed { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
