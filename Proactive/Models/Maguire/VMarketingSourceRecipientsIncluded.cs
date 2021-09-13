using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMarketingSourceRecipientsIncluded
    {
        public Guid SrcId { get; set; }
        public long MsrId { get; set; }
        public long ExcludeId { get; set; }
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public int? CsId { get; set; }
        public int Included { get; set; }
        public string AccSummary { get; set; }
        public string AcSummary { get; set; }
        public bool ValidEmail { get; set; }
        public byte EmailInvalidReason { get; set; }
        public bool ValidFax { get; set; }
        public byte FaxInvalidReason { get; set; }
        public bool ValidLetter { get; set; }
        public byte LetterInvalidReason { get; set; }
        public bool ValidPhone { get; set; }
        public byte PhoneInvalidReason { get; set; }
        public bool ValidSms { get; set; }
        public byte SmsInvalidReason { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Address1 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string Mobile { get; set; }
        public string SrcType { get; set; }
        public string Country { get; set; }
        public string Jobtitle { get; set; }
    }
}
