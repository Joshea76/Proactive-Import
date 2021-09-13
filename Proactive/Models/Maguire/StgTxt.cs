using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StgTxt
    {
        public Guid StgTxtId { get; set; }

        public virtual MarketingCampaignStage StgTxtNavigation { get; set; }
    }
}
