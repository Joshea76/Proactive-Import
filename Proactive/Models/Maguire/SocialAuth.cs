using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SocialAuth
    {
        public SocialAuth()
        {
            MarketingCampaignStageMessageSenders = new HashSet<MarketingCampaignStageMessageSender>();
            SocialAuthIntegrations = new HashSet<SocialAuthIntegration>();
        }

        public Guid SocId { get; set; }
        public Guid? UsId { get; set; }
        public Guid? TpiId { get; set; }
        public string Summary { get; set; }
        public string TypeName { get; set; }
        public string ThirdPartyId { get; set; }
        public string ThirdPartyName { get; set; }
        public string ThirdPartyUsername { get; set; }
        public string ThirdPartyPassword { get; set; }
        public string ProfileUrl { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
        public string Data3 { get; set; }
        public string Data4 { get; set; }
        public string Data5 { get; set; }
        public byte[] Certificate { get; set; }
        public DateTime? LastUsed { get; set; }
        public bool? Bounced { get; set; }
        public DateTime? LastBounced { get; set; }
        public string LastBounceMessage { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Data6 { get; set; }
        public string Data7 { get; set; }
        public string Data8 { get; set; }
        public string Data9 { get; set; }
        public string Data10 { get; set; }
        public Guid? ItemId { get; set; }
        public string ItemType { get; set; }

        public virtual User Us { get; set; }
        public virtual ICollection<MarketingCampaignStageMessageSender> MarketingCampaignStageMessageSenders { get; set; }
        public virtual ICollection<SocialAuthIntegration> SocialAuthIntegrations { get; set; }
    }
}
