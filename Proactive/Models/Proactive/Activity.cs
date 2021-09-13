using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityDesc { get; set; }
        public DateTime DateCreated { get; set; }
        public int ActivityTypeId { get; set; }
        public int ContactId { get; set; }
        public string UserId { get; set; }
        public int? SalesStepId { get; set; }
        public int? SalesProcessId { get; set; }
        public string ExternalEmailId { get; set; }
        public int? EmailType { get; set; }
        public string EmailFolder { get; set; }
        public int? OpportunityId { get; set; }
        public int? MailchimpCampaignId { get; set; }
        public int? EmailId { get; set; }

        public virtual ActivityType ActivityType { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Email Email { get; set; }
        public virtual MailchimpCampaign MailchimpCampaign { get; set; }
        public virtual Opportunity Opportunity { get; set; }
        public virtual SalesProcess SalesProcess { get; set; }
        public virtual SalesStep SalesStep { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
