using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMarketingCampaignStageRunStat
    {
        public Guid McsrId { get; set; }
        public int TltOpened { get; set; }
        public int TltClicked { get; set; }
        public int TltDelivered { get; set; }
        public int TltReplied { get; set; }
        public int TltBounced { get; set; }
        public int TltUnsubthis { get; set; }
        public int TltUnsuball { get; set; }
        public int? UnqOpened { get; set; }
        public int? UnqClicked { get; set; }
        public int? UnqDelivered { get; set; }
        public int? UnqReplied { get; set; }
        public int? UnqBounced { get; set; }
        public int? UnqUnsubthis { get; set; }
        public int? UnqUnsuball { get; set; }
    }
}
