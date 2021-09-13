using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntWinManTransactionHistory
    {
        public IntWinManTransactionHistory()
        {
            IntWinmanTransactionHistoryLines = new HashSet<IntWinmanTransactionHistoryLine>();
        }

        public Guid WinThId { get; set; }
        public Guid AcId { get; set; }
        public Guid ObjId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid FneId { get; set; }
        public string Source { get; set; }
        public string CustomerGuid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string WinThUd1Text { get; set; }
        public string WinThUd2Text { get; set; }
        public string WinThUd3Text { get; set; }
        public string WinThUd4Text { get; set; }
        public string WinThUd5Text { get; set; }
        public decimal? WinThUd1Numeric { get; set; }
        public decimal? WinThUd2Numeric { get; set; }
        public decimal? WinThUd3Numeric { get; set; }
        public decimal? WinThUd4Numeric { get; set; }
        public decimal? WinThUd5Numeric { get; set; }
        public DateTime? WinThUd1Date { get; set; }
        public DateTime? WinThUd2Date { get; set; }
        public DateTime? WinThUd3Date { get; set; }
        public DateTime? WinThUd4Date { get; set; }
        public DateTime? WinThUd5Date { get; set; }
        public Guid? WinThUd1Id { get; set; }
        public Guid? WinThUd2Id { get; set; }
        public Guid? WinThUd3Id { get; set; }
        public Guid? WinThUd4Id { get; set; }
        public Guid? WinThUd5Id { get; set; }
        public bool? WinThUd1Bit { get; set; }
        public bool? WinThUd2Bit { get; set; }
        public bool? WinThUd3Bit { get; set; }
        public bool? WinThUd4Bit { get; set; }
        public bool? WinThUd5Bit { get; set; }
        public string InvoiceId { get; set; }
        public string SalesOrderId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoiceDueDate { get; set; }
        public string InvoiceStatus { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public decimal? OutstandingBalance { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string FreightMethodId { get; set; }
        public decimal? ShippingValue { get; set; }
        public decimal? ShippingTaxValue { get; set; }
        public decimal? TotalOrderValue { get; set; }
        public decimal? TotalTaxValue { get; set; }
        public string Currency { get; set; }
        public string ShippingName { get; set; }
        public string ShippingTitle { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingRegion { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingCountryCode { get; set; }
        public string ShippingPhoneNumber { get; set; }
        public string ShippingEmailAddress { get; set; }
        public string BillingName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingRegion { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingCountryCode { get; set; }
        public string BillingPhoneNumber { get; set; }
        public string BillingEmailAddress { get; set; }
        public string QuoteId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? QuoteDate { get; set; }
        public decimal? TotalQuoteValue { get; set; }
        public string PaymentType { get; set; }
        public string CustomerContact { get; set; }
        public string OrderStatus { get; set; }
        public string QuoteStatus { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingUrl { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual Account Obj { get; set; }
        public virtual ICollection<IntWinmanTransactionHistoryLine> IntWinmanTransactionHistoryLines { get; set; }
    }
}
