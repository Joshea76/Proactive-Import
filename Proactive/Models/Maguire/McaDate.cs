using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class McaDate
    {
        public Guid McaDateId { get; set; }

        public virtual MarketingCampaign McaDateNavigation { get; set; }
    }
}
