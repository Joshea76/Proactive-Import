using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class McaUid
    {
        public Guid McaUidId { get; set; }

        public virtual MarketingCampaign McaUidNavigation { get; set; }
    }
}
