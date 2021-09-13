using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmMailRunRecipient
    {
        public LmMailRunRecipient()
        {
            LmMailRunClickdata = new HashSet<LmMailRunClickdatum>();
        }

        public Guid LmrrId { get; set; }
        public Guid LmrId { get; set; }
        public int CsId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? GvcSentDate { get; set; }
        public bool? GvcSentFlag { get; set; }
        public DateTime? GvcReadDate { get; set; }
        public bool? GvcReadFlag { get; set; }
        public DateTime? GvcClickThruDate { get; set; }
        public bool? GvcClickThruFlag { get; set; }
        public DateTime? GvcUnsubDate { get; set; }
        public bool? GvcUnsubThis { get; set; }
        public bool? GvcUnsubAll { get; set; }
        public DateTime? GvcRepliedDate { get; set; }
        public bool? GvcRepliedFlag { get; set; }
        public short? GvcRepliedCount { get; set; }
        public DateTime? GvcForwardDate { get; set; }
        public bool? GvcForwardFlag { get; set; }
        public short? GvcForwardCount { get; set; }
        public bool? GvcBounceFlag { get; set; }
        public string GvcBounceCode { get; set; }
        public string GvcBounceText { get; set; }
        public int? GvcLinksClickedCount { get; set; }

        public virtual LmContactSpine Cs { get; set; }
        public virtual LmMailRun Lmr { get; set; }
        public virtual ICollection<LmMailRunClickdatum> LmMailRunClickdata { get; set; }
    }
}
