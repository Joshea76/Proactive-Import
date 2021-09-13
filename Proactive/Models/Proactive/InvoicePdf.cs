using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class InvoicePdf
    {
        public int JobHeaderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyBankInfo { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Website { get; set; }
        public string ContactName { get; set; }
        public int ContactId { get; set; }
        public string ContactNote { get; set; }
        public string Number { get; set; }
        public DateTime PaymentDue { get; set; }
        public DateTime DatePdfcreated { get; set; }
        public string PaymentDueStr { get; set; }
        public string ContactAddress1 { get; set; }
        public string ContactAddress2 { get; set; }
        public string ContactAddress3 { get; set; }
        public string ContactCity { get; set; }
        public string ContactState { get; set; }
        public string ContactPostCode { get; set; }
        public int? ContactCountryId { get; set; }
        public int? OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgAddress { get; set; }
        public string OrgPostCode { get; set; }
    }
}
