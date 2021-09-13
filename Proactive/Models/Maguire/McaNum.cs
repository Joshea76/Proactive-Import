using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class McaNum
    {
        public Guid McaNumId { get; set; }

        public virtual MarketingCampaign McaNumNavigation { get; set; }
    }
}
