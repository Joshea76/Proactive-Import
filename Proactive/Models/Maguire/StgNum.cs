using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StgNum
    {
        public Guid StgNumId { get; set; }

        public virtual MarketingCampaignStage StgNumNavigation { get; set; }
    }
}
