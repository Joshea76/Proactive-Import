using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Process
    {
        public Process()
        {
            ProcessContacts = new HashSet<ProcessContact>();
            ProcessSteps = new HashSet<ProcessStep>();
        }

        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string ProcessDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UserId { get; set; }
        public int ProcessType { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ProcessContact> ProcessContacts { get; set; }
        public virtual ICollection<ProcessStep> ProcessSteps { get; set; }
    }
}
