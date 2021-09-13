using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SystemEmail
    {
        public SystemEmail()
        {
            SystemEmailSubscriptions = new HashSet<SystemEmailSubscription>();
        }

        public int SystemEmailId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int AfterPreviousEmailDaysCount { get; set; }
        public int EmailNumber { get; set; }
        public int EmailType { get; set; }
        public bool Published { get; set; }

        public virtual ICollection<SystemEmailSubscription> SystemEmailSubscriptions { get; set; }
    }
}
