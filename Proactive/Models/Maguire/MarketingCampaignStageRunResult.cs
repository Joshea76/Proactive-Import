using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingCampaignStageRunResult
    {
        public long McsrrId { get; set; }
        public Guid? ActId { get; set; }
        public Guid McsrId { get; set; }
        public Guid McsrrGuid { get; set; }
        public Guid StgId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? AcId { get; set; }
        public int? CsId { get; set; }
        public Guid SrcId { get; set; }
        public bool IsValid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? EmailOpened { get; set; }
        public DateTime? EmailOpenedDate { get; set; }
        public bool? EmailClicked { get; set; }
        public DateTime? EmailClickedDate { get; set; }
        public bool? EmailDelivered { get; set; }
        public DateTime? EmailDeliveredDate { get; set; }
        public bool? EmailReplied { get; set; }
        public DateTime? EmailRepliedDate { get; set; }
        public bool? EmailForwarded { get; set; }
        public DateTime? EmailForwardedDate { get; set; }
        public bool? EmailBounced { get; set; }
        public DateTime? EmailBouncedDate { get; set; }
        public string EmailBouncedCode { get; set; }
        public bool? EmailUnsubthis { get; set; }
        public DateTime? EmailUnsubthisDate { get; set; }
        public bool? EmailUnsuball { get; set; }
        public DateTime? EmailUnsuballDate { get; set; }
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
        public string DeletedBy { get; set; }
        public bool? McsrrDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual Activity Act { get; set; }
        public virtual MarketingCampaignStageRun Mcsr { get; set; }
        public virtual MarketingSource Src { get; set; }
        public virtual MarketingCampaignStage Stg { get; set; }
    }
}
