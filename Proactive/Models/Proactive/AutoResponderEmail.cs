using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class AutoResponderEmail
    {
        public int CampaignEmailId { get; set; }
        public string SubjectLine { get; set; }
        public string Body { get; set; }
        public int NumberOfDaysAfterPreviousEmail { get; set; }
        public int EmailNumber { get; set; }
        public bool Publish { get; set; }
        public int CampaignId { get; set; }

        public virtual AutoResponder Campaign { get; set; }
    }
}
