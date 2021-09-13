using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class JobHeader
    {
        public JobHeader()
        {
            JobItems = new HashSet<JobItem>();
            Jobs = new HashSet<Job>();
        }

        public int JobHeaderId { get; set; }
        public int ContactId { get; set; }
        public string UserId { get; set; }
        public DateTime PaymentDue { get; set; }
        public bool IsPaid { get; set; }
        public string ContactNote { get; set; }
        public int Number { get; set; }
        public DateTime DateCreated { get; set; }
        public int? HeaderType { get; set; }
        public int JobNumber { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<JobItem> JobItems { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
