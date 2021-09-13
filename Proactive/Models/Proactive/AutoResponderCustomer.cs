using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class AutoResponderCustomer
    {
        public int CampaignCustomerId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public bool OptedIn { get; set; }
        public int CampaignId { get; set; }
        public DateTime? DateOptedIn { get; set; }

        public virtual AutoResponder Campaign { get; set; }
    }
}
