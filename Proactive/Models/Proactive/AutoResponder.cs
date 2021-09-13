using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class AutoResponder
    {
        public AutoResponder()
        {
            AutoResponderCustomers = new HashSet<AutoResponderCustomer>();
            AutoResponderEmails = new HashSet<AutoResponderEmail>();
        }

        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Start { get; set; }
        public bool DoubleOptIn { get; set; }
        public string CampaignCode { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<AutoResponderCustomer> AutoResponderCustomers { get; set; }
        public virtual ICollection<AutoResponderEmail> AutoResponderEmails { get; set; }
    }
}
