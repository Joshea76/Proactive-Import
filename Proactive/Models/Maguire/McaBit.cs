using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class McaBit
    {
        public Guid McaBitId { get; set; }

        public virtual MarketingCampaign McaBitNavigation { get; set; }
    }
}
