using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStageMessage
    {
        public MarketingCampaignStageMessage()
        {
            MarketingCampaignStageMessageSenders = new HashSet<MarketingCampaignStageMessageSender>();
        }

        public Guid SocmesId { get; set; }
        public Guid StgId { get; set; }
        public Guid? McsrId { get; set; }
        public string MessageShort { get; set; }
        public string MessageLong { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool SocmesDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public short State { get; set; }
        public DateTime? ScheduledRunDate { get; set; }
        public DateTime? ActualRunDate { get; set; }

        public virtual MarketingCampaignStageRun Mcsr { get; set; }
        public virtual MarketingCampaignStage Stg { get; set; }
        public virtual ICollection<MarketingCampaignStageMessageSender> MarketingCampaignStageMessageSenders { get; set; }
    }
}
