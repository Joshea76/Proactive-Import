using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OpportunityStageHistory
    {
        public int OpportunityStageHistoryId { get; set; }
        public int? StartStageId { get; set; }
        public int? EndStageId { get; set; }
        public DateTime DateOfChange { get; set; }
        public int OpportunityId { get; set; }
        public int ContactId { get; set; }
        public string UserId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual OpportunityStage EndStage { get; set; }
        public virtual Opportunity Opportunity { get; set; }
        public virtual OpportunityStage StartStage { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
