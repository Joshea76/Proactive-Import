using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class StgUid
    {
        public Guid StgUidId { get; set; }

        public virtual MarketingCampaignStage StgUidNavigation { get; set; }
    }
}
