using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PrivacyRule
    {
        public PrivacyRule()
        {
            PrivacyLogs = new HashSet<PrivacyLog>();
            PrivacyRulesOptions = new HashSet<PrivacyRulesOption>();
        }

        public Guid PrrId { get; set; }
        public Guid PrrPuId { get; set; }
        public string PrrRuleName { get; set; }
        public int PrrRuleTypeId { get; set; }
        public string PrrRuleDefinitionId { get; set; }
        public bool PrrActive { get; set; }
        public bool? PrrNotification { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? PrrDeleted { get; set; }

        public virtual Purpose PrrPu { get; set; }
        public virtual ICollection<PrivacyLog> PrivacyLogs { get; set; }
        public virtual ICollection<PrivacyRulesOption> PrivacyRulesOptions { get; set; }
    }
}
