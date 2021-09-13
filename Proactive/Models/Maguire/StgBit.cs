using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StgBit
    {
        public Guid StgBitId { get; set; }

        public virtual MarketingCampaignStage StgBitNavigation { get; set; }
    }
}
