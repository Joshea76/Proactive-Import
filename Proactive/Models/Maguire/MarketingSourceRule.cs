﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingSourceRule
    {
        public MarketingSourceRule()
        {
            MarketingSourceQueries = new HashSet<MarketingSourceQuery>();
            MarketingSourceRecipients = new HashSet<MarketingSourceRecipient>();
        }

        public int RulId { get; set; }
        public Guid SrcId { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? LastRefresh { get; set; }
        public string LastRefreshBy { get; set; }
        public int CValidEmail { get; set; }
        public int CValidPhone { get; set; }
        public int CValidFax { get; set; }
        public int CValidLetter { get; set; }
        public int CValidSms { get; set; }
        public int CTotal { get; set; }
        public byte RuleType { get; set; }
        public Guid? AccId { get; set; }
        public Guid? ObjId { get; set; }
        public string ObjType { get; set; }
        public byte RuleOption { get; set; }
        public bool DefaultToAccount { get; set; }
        public int? CsId { get; set; }

        public virtual AccountsContact Acc { get; set; }
        public virtual MarketingSource Src { get; set; }
        public virtual ICollection<MarketingSourceQuery> MarketingSourceQueries { get; set; }
        public virtual ICollection<MarketingSourceRecipient> MarketingSourceRecipients { get; set; }
    }
}
