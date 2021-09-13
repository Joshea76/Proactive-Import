using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OpportunityStage
    {
        public OpportunityStage()
        {
            Opportunities = new HashSet<Opportunity>();
            OpportunityStageHistoryEndStages = new HashSet<OpportunityStageHistory>();
            OpportunityStageHistoryStartStages = new HashSet<OpportunityStageHistory>();
        }

        public int OpportunityStageId { get; set; }
        public string OpportunityStageName { get; set; }
        public int Order { get; set; }
        public string UserId { get; set; }
        public bool DisplayInReports { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Opportunity> Opportunities { get; set; }
        public virtual ICollection<OpportunityStageHistory> OpportunityStageHistoryEndStages { get; set; }
        public virtual ICollection<OpportunityStageHistory> OpportunityStageHistoryStartStages { get; set; }
    }
}
