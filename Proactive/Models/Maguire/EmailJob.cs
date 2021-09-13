using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EmailJob
    {
        public EmailJob()
        {
            EmailJobsRecipients = new HashSet<EmailJobsRecipient>();
        }

        public Guid EjId { get; set; }
        public Guid UsId { get; set; }
        public int State { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Guid? CoId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Correspondence Co { get; set; }
        public virtual User Us { get; set; }
        public virtual ICollection<EmailJobsRecipient> EmailJobsRecipients { get; set; }
    }
}
