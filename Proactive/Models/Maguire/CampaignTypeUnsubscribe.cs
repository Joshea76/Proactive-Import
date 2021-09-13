using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class CampaignTypeUnsubscribe
    {
        public Guid CtuId { get; set; }
        public Guid? AccId { get; set; }
        public bool Subscribed { get; set; }
        public Guid? MacType { get; set; }
        public Guid? AcId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OptionDate { get; set; }
        public int? CsId { get; set; }
    }
}
