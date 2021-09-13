using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VCorrespondence
    {
        public Guid CoId { get; set; }
        public Guid? CoRef { get; set; }
        public Guid? CoAccId { get; set; }
        public bool CoDeleted { get; set; }
        public string Type { get; set; }
        public string CoMapiId { get; set; }
        public string CoStoreId { get; set; }
        public DateTime? DateSent { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string RecipientAddress { get; set; }
        public string SenderAddress { get; set; }
        public bool? Private { get; set; }
        public bool? ManualPending { get; set; }
        public DateTime? ManualCreatedDate { get; set; }
        public Guid? ManualUsId { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public Guid? MailboxUsId { get; set; }
        public int? Attachments { get; set; }
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public string AcName { get; set; }
        public string AccName { get; set; }
        public string Email1Address { get; set; }
        public string AcGroup { get; set; }
        public Guid? UsIdSales { get; set; }
        public string AcType { get; set; }
        public string AcType2 { get; set; }
        public string AcTypeHlight { get; set; }
        public string AcType2Hlight { get; set; }
        public string AcIndustry { get; set; }
        public string AcIndustryHlight { get; set; }
        public string AcSource { get; set; }
        public string AcSourceHlight { get; set; }
        public string AcLabel { get; set; }
        public string AcLabelHlight { get; set; }
        public string AcLevel { get; set; }
        public string AcLevelHlight { get; set; }
        public string AccountManager { get; set; }
        public Guid? UsgId { get; set; }
        public string UsgName { get; set; }
        public Guid CoType { get; set; }
        public string CoTypeName { get; set; }
        public string HtmlBody { get; set; }
        public string ShortCode { get; set; }
    }
}
