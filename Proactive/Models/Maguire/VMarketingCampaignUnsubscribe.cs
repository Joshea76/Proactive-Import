using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMarketingCampaignUnsubscribe
    {
        public Guid McsrrGuid { get; set; }
        public Guid? AccId { get; set; }
        public Guid? AcId { get; set; }
        public int CsId { get; set; }
        public string AccSummary { get; set; }
        public string PrimaryEmail { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string AcSummary { get; set; }
        public DateTime? EmailUnsuballDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string GvType { get; set; }
    }
}
