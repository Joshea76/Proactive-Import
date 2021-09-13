using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VStageFollowUpRecipientInformationLead
    {
        public Guid? SrcId { get; set; }
        public byte StageType { get; set; }
        public Guid StgId { get; set; }
        public int? AccId { get; set; }
        public int? AcId { get; set; }
        public int? CsId { get; set; }
        public bool? ValidEmail { get; set; }
        public bool? ValidLetter { get; set; }
        public bool? ValidSms { get; set; }
        public bool? ValidFax { get; set; }
        public bool? ValidPhone { get; set; }
        public byte? EmailInvalidReason { get; set; }
        public byte? FaxInvalidReason { get; set; }
        public byte? LetterInvalidReason { get; set; }
        public byte? PhoneInvalidReason { get; set; }
        public byte? SmsInvalidReason { get; set; }
        public bool? IsSent { get; set; }
        public DateTime? LastSent { get; set; }
        public int CEmailOpen { get; set; }
        public int CEmailClicked { get; set; }
        public int CEmailDelivered { get; set; }
        public int CEmailReplied { get; set; }
        public int CEmailForwarded { get; set; }
        public int CEmailBounced { get; set; }
        public int CEmailUnsubd { get; set; }
    }
}
