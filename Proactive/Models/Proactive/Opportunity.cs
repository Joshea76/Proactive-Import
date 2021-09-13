using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Opportunity
    {
        public Opportunity()
        {
            Activities = new HashSet<Activity>();
            ContactNotes = new HashSet<ContactNote>();
            OpportunityStageHistories = new HashSet<OpportunityStageHistory>();
            Todos = new HashSet<Todo>();
        }

        public int OpportunityId { get; set; }
        public string OpportunityName { get; set; }
        public int? ProductId { get; set; }
        public string OpportunityDescription { get; set; }
        public decimal? OpportunityValue { get; set; }
        public string NextThing { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? OpportunityStageId { get; set; }
        public int ContactId { get; set; }
        public string UserId { get; set; }
        public bool Closed { get; set; }
        public string CloseReasonDescription { get; set; }
        public DateTime? ActualCloseDate { get; set; }
        public int CloseReason { get; set; }
        public int? SourceId { get; set; }
        public DateTime DateUpdated { get; set; }
        public decimal Quantity { get; set; }
        public int Probability { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual OpportunityStage OpportunityStage { get; set; }
        public virtual Product Product { get; set; }
        public virtual Source Source { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ContactNote> ContactNotes { get; set; }
        public virtual ICollection<OpportunityStageHistory> OpportunityStageHistories { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}
