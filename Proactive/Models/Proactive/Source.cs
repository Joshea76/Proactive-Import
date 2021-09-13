using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Source
    {
        public Source()
        {
            Contacts = new HashSet<Contact>();
            Opportunities = new HashSet<Opportunity>();
        }

        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public string UserId { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
    }
}
