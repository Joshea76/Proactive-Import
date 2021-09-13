using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStageRecipient
    {
        public long MtrId { get; set; }
        public Guid StgId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? AcId { get; set; }
        public int? CsId { get; set; }
        public Guid? SrcId { get; set; }
        public bool? ValidEmail { get; set; }
        public bool? ValidLetter { get; set; }
        public bool? ValidFax { get; set; }
        public bool? ValidPhone { get; set; }
        public bool? ValidSms { get; set; }
        public byte? EmailInvalidReason { get; set; }
        public byte? FaxInvalidReason { get; set; }
        public byte? LetterInvalidReason { get; set; }
        public byte? PhoneInvalidReason { get; set; }
        public byte? SmsInvalidReason { get; set; }
        public short? Rownum { get; set; }

        public virtual Account Ac { get; set; }
        public virtual MarketingSource Src { get; set; }
        public virtual MarketingCampaignStage Stg { get; set; }
    }
}
