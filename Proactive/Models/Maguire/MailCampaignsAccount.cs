using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaignsAccount
    {
        public Guid MacId { get; set; }
        public Guid MacacId { get; set; }
        public Guid AcId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? McrId { get; set; }

        public virtual Account Ac { get; set; }
        public virtual MailCampaign Mac { get; set; }
        public virtual MailCampaignsRun Mcr { get; set; }
    }
}
