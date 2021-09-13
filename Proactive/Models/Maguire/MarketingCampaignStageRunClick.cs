using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStageRunClick
    {
        public int MclId { get; set; }
        public Guid McsrId { get; set; }
        public Guid AccId { get; set; }
        public int? CsId { get; set; }
        public DateTime DateClicked { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }

        public virtual MarketingCampaignStageRun Mcsr { get; set; }
    }
}
