using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MailCampaignsContactsUnsent
    {
        public Guid MacId { get; set; }
        public Guid MaccuId { get; set; }
        public Guid AcId { get; set; }
        public Guid AccId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Add { get; set; }
        public Guid? McsId { get; set; }
        public bool? Removed { get; set; }
        public bool? Forced { get; set; }
        public bool? GvcUnsubThis { get; set; }
        public bool? IsNew { get; set; }
        public Guid? SembId { get; set; }

        public virtual MailCampaign Mac { get; set; }
    }
}
