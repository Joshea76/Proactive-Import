using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SalesProcess
    {
        public SalesProcess()
        {
            Activities = new HashSet<Activity>();
            Contacts = new HashSet<Contact>();
            SalesSteps = new HashSet<SalesStep>();
        }

        public int Id { get; set; }
        public string SalesProcessName { get; set; }
        public string SalesProcessDesc { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<SalesStep> SalesSteps { get; set; }
    }
}
