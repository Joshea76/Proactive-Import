using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Job
    {
        public Job()
        {
            JobItems = new HashSet<JobItem>();
            JobNotes = new HashSet<JobNote>();
        }

        public int JobId { get; set; }
        public int JobHeaderId { get; set; }
        public string Description { get; set; }
        public int JobNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDoneBy { get; set; }
        public DateTime? DateCompleted { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
        public string DateDoneByMessage { get; set; }
        public bool Closed { get; set; }
        public string TempContactId { get; set; }
        public string TempJobheaderId { get; set; }

        public virtual JobHeader JobHeader { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<JobItem> JobItems { get; set; }
        public virtual ICollection<JobNote> JobNotes { get; set; }
    }
}
