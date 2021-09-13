using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VUnsubscribe
    {
        public Guid CtuId { get; set; }
        public string Summary { get; set; }
        public Guid AccId { get; set; }
        public Guid? AcId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OptionDate { get; set; }
        public bool Subscribed { get; set; }
        public string CampaignType { get; set; }
        public string Accountname { get; set; }
        public string Email1Address { get; set; }
    }
}
