using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactProcessStep
    {
        public int ContactProcessStepId { get; set; }
        public int ProcessId { get; set; }
        public int StepId { get; set; }
        public int ContactId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCurrentStep { get; set; }
        public string UserId { get; set; }
        public bool Done { get; set; }
        public DateTime? DoBy { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
