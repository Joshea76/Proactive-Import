using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class MailchimpCampaign
    {
        public MailchimpCampaign()
        {
            Activities = new HashSet<Activity>();
        }

        public int MailchimpCampaignId { get; set; }
        public string CampaignId { get; set; }
        public string CampaignTitle { get; set; }
        public string ListId { get; set; }
        public string ListTitle { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserId { get; set; }
        public int? EmailsSent { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
