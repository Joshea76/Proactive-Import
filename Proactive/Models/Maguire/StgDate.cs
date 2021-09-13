using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StgDate
    {
        public Guid StgDateId { get; set; }

        public virtual MarketingCampaignStage StgDateNavigation { get; set; }
    }
}
