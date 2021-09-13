using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VContactUnsubscribe
    {
        public Guid DroId { get; set; }
        public string CampaignType { get; set; }
        public Guid? AccId { get; set; }
        public Guid? MacType { get; set; }
        public bool? Subscribed { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OptionDate { get; set; }
        public DateTime? DroCreatedDate { get; set; }
    }
}
