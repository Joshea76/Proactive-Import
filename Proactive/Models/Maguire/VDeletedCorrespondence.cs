using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VDeletedCorrespondence
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
        public string ShortCode { get; set; }
        public string Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Ud1 { get; set; }
        public string Ud2 { get; set; }
        public string Ud3 { get; set; }
        public string Ud4 { get; set; }
        public string Ud5 { get; set; }
        public string Ud6 { get; set; }
        public string Ud7 { get; set; }
        public string Ud8 { get; set; }
        public string Ud9 { get; set; }
        public string Ud10 { get; set; }
        public string Ud11 { get; set; }
        public string Ud12 { get; set; }
        public string Ud13 { get; set; }
        public string Ud14 { get; set; }
        public string Ud15 { get; set; }
        public string RecipientAddress { get; set; }
        public string SenderAddress { get; set; }
        public bool? Private { get; set; }
        public bool? ManualPending { get; set; }
        public DateTime? ManualCreatedDate { get; set; }
        public Guid? ManualUsId { get; set; }
        public Guid? MailboxUsId { get; set; }
        public string HtmlBody { get; set; }
        public string MailKey { get; set; }
        public Guid CoType { get; set; }
        public string AcName { get; set; }
    }
}
