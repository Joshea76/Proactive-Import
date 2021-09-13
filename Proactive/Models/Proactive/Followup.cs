using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Followup
    {
        public int FollowupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ListId { get; set; }
        public int ProcessId { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
