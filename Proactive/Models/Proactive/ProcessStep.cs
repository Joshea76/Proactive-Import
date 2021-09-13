using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ProcessStep
    {
        public int StepId { get; set; }
        public string StepName { get; set; }
        public string StepDescription { get; set; }
        public int StepOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UserId { get; set; }
        public int ProcessId { get; set; }
        public DateTime? DoBy { get; set; }
        public int DaysAfterPreviousStep { get; set; }
        public string Content { get; set; }

        public virtual Process Process { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
