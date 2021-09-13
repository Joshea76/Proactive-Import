using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class SalesStep
    {
        public SalesStep()
        {
            Activities = new HashSet<Activity>();
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string StepName { get; set; }
        public string StepDesc { get; set; }
        public int StepOrder { get; set; }
        public int SalesProcessId { get; set; }
        public string UserId { get; set; }

        public virtual SalesProcess SalesProcess { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
