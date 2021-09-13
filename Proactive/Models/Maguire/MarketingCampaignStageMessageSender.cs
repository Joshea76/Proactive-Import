using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStageMessageSender
    {
        public Guid SocsendId { get; set; }
        public Guid? SocId { get; set; }
        public Guid SocmesId { get; set; }
        public string SubAccountName { get; set; }
        public string SubAccountId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool Complete { get; set; }
        public DateTime? RunDate { get; set; }
        public string RunErrMsg { get; set; }
        public string ThirdPartyId { get; set; }
        public string ThirdPartyUrl { get; set; }
        public int? CClicks { get; set; }

        public virtual SocialAuth Soc { get; set; }
        public virtual MarketingCampaignStageMessage Socmes { get; set; }
    }
}
