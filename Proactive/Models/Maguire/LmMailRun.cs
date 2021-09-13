using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmMailRun
    {
        public LmMailRun()
        {
            LmMailRunClickdata = new HashSet<LmMailRunClickdatum>();
            LmMailRunRecipients = new HashSet<LmMailRunRecipient>();
        }

        public Guid LmrId { get; set; }
        public int? LsId { get; set; }
        public int? LcId { get; set; }
        public Guid Owner { get; set; }
        public string Summary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid MailRunType { get; set; }
        public string RecipientFilter { get; set; }
        public byte? GvConnectUploaded { get; set; }
        public DateTime? GvConnectUploadedDate { get; set; }
        public string GvConnectUploadedMsg { get; set; }
        public int? GvcSentCount { get; set; }
        public int? GvcReadCount { get; set; }
        public int? GvcClickThruCount { get; set; }
        public int? GvcUnsubThisCount { get; set; }
        public int? GvcUnsubAllCount { get; set; }
        public int? GvcRepliedCount { get; set; }
        public int? GvcForwardCount { get; set; }
        public int? GvcBounceCount { get; set; }
        public int? GvcUploadedCount { get; set; }

        public virtual LmListcontrol Lc { get; set; }
        public virtual ICollection<LmMailRunClickdatum> LmMailRunClickdata { get; set; }
        public virtual ICollection<LmMailRunRecipient> LmMailRunRecipients { get; set; }
    }
}
