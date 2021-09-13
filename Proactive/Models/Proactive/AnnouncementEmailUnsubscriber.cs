using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class AnnouncementEmailUnsubscriber
    {
        public int AnnouncementEmailUnsubscriberId { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
