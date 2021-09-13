using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SystemEmailSubscription
    {
        public int SystemEmailSubscriptionId { get; set; }
        public string UserId { get; set; }
        public Guid? SystemEmailUnsubscribeId { get; set; }
        public int? LastSystemEmailId { get; set; }
        public DateTime? LastSystemEmailDate { get; set; }
        public int EmailType { get; set; }

        public virtual SystemEmail LastSystemEmail { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
