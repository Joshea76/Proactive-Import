using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactNote
    {
        public int ContactNoteId { get; set; }
        public int? ContactId { get; set; }
        public string Note { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserId { get; set; }
        public int? OpportunityId { get; set; }
        public int? OrgId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Opportunity Opportunity { get; set; }
        public virtual Org Org { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
