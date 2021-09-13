using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Quote
    {
        public Quote()
        {
            QuoteItems = new HashSet<QuoteItem>();
        }

        public int QuoteId { get; set; }
        public int QuoteNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UserId { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateAccepted { get; set; }
        public int? ContactId { get; set; }
        public string MyNote { get; set; }
        public string ContactNote { get; set; }
        public int? OrgId { get; set; }
        public string QuoteName { get; set; }
        public DateTime? DateClosed { get; set; }
        public string AssignedUserId { get; set; }

        public virtual AspNetUser AssignedUser { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Org Org { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
    }
}
