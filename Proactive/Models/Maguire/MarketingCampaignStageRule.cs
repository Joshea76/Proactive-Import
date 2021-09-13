using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStageRule
    {
        public Guid StgrulId { get; set; }
        public Guid StgId { get; set; }
        public short? MajorFollowupOpt { get; set; }
        public short? FollowupOpt { get; set; }
        public string Value { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
