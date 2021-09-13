using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaignsContactsSentClick
    {
        public Guid MaccscId { get; set; }
        public Guid MaccsId { get; set; }
        public Guid AcId { get; set; }
        public Guid AccId { get; set; }
        public Guid RsaId { get; set; }
        public DateTime DateClicked { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public int? IMaccsId { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual MailCampaignsContactsSent IMaccs { get; set; }
    }
}
