using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class DomainActivity
    {
        public int DomainActivityId { get; set; }
        public int Activity { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ContactId { get; set; }
        public string UserId { get; set; }
        public int? OrgId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Org Org { get; set; }
    }
}
