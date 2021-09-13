using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMarketingCampaignStageStat
    {
        public Guid StgId { get; set; }
        public int? CTltEmailsOpened { get; set; }
        public int? CTltEmailsClicked { get; set; }
        public int? CTltEmailsDelivered { get; set; }
        public int? CTltEmailsReplied { get; set; }
        public int? CTltEmailsBounced { get; set; }
        public int? CTltEmailsUnsubthis { get; set; }
        public int? CTltEmailsUnsuball { get; set; }
        public int? CUnqEmailsOpened { get; set; }
        public int? CUnqEmailsClicked { get; set; }
        public int? CUnqEmailsDelivered { get; set; }
        public int? CUnqEmailsReplied { get; set; }
        public int? CUnqEmailsBounced { get; set; }
        public int? CUnqEmailsUnsubthis { get; set; }
        public int? CUnqEmailsUnsuball { get; set; }
    }
}
