using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwIntXeroTransactionHistory
    {
        public Guid XeroThId { get; set; }
        public string XeroThNumber { get; set; }
        public Guid AcId { get; set; }
        public Guid ObjId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid FneId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string XeroThUd1Text { get; set; }
        public string XeroThUd2Text { get; set; }
        public string XeroThUd3Text { get; set; }
        public string XeroThUd4Text { get; set; }
        public string XeroThUd5Text { get; set; }
        public decimal? XeroThUd1Numeric { get; set; }
        public decimal? XeroThUd2Numeric { get; set; }
        public decimal? XeroThUd3Numeric { get; set; }
        public decimal? XeroThUd4Numeric { get; set; }
        public decimal? XeroThUd5Numeric { get; set; }
        public DateTime? XeroThUd1Date { get; set; }
        public DateTime? XeroThUd2Date { get; set; }
        public DateTime? XeroThUd3Date { get; set; }
        public DateTime? XeroThUd4Date { get; set; }
        public DateTime? XeroThUd5Date { get; set; }
        public Guid? XeroThUd1Id { get; set; }
        public Guid? XeroThUd2Id { get; set; }
        public Guid? XeroThUd3Id { get; set; }
        public Guid? XeroThUd4Id { get; set; }
        public Guid? XeroThUd5Id { get; set; }
        public bool? XeroThUd1Bit { get; set; }
        public bool? XeroThUd2Bit { get; set; }
        public bool? XeroThUd3Bit { get; set; }
        public bool? XeroThUd4Bit { get; set; }
        public bool? XeroThUd5Bit { get; set; }
        public string InvoiceNumber { get; set; }
        public string Summary { get; set; }
        public string InvoiceId { get; set; }
        public string ContactId { get; set; }
        public string Type { get; set; }
        public string BrandingThemeId { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? AmountDue { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ExpectedPaymentDate { get; set; }
        public string Reference { get; set; }
        public string Url { get; set; }
        public string Status { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? CurrencyRate { get; set; }
        public bool? SentToContact { get; set; }
        public string LineAmountTypes { get; set; }
        public DateTime? UpdatedDateUtc { get; set; }
        public DateTime? PlannedPaymentDate { get; set; }
        public bool? HasAttachments { get; set; }
        public DateTime? FullyPaidOnDate { get; set; }
        public decimal? AmountCredited { get; set; }
        public decimal? CisDeduction { get; set; }
        public string ShortCode { get; set; }
        public string AccountName { get; set; }
        public Guid? AccIdSales { get; set; }
        public string AcContactName { get; set; }
        public Guid? AcgId { get; set; }
        public Guid? UsIdSales { get; set; }
        public string GvAccountType { get; set; }
        public string GvContactType { get; set; }
        public string FneName { get; set; }
    }
}
