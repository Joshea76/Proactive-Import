using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class McaTxt
    {
        public Guid McaTxtId { get; set; }

        public virtual MarketingCampaign McaTxtNavigation { get; set; }
    }
}
