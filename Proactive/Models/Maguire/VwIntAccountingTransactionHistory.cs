using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwIntAccountingTransactionHistory
    {
        public string Summary { get; set; }
        public Guid ThId { get; set; }
        public Guid AcId { get; set; }
        public Guid ObjId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid FneId { get; set; }
        public string Source { get; set; }
        public string CustomerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string ThUd1Text { get; set; }
        public string ThUd2Text { get; set; }
        public string ThUd3Text { get; set; }
        public string ThUd4Text { get; set; }
        public string ThUd5Text { get; set; }
        public decimal? ThUd1Numeric { get; set; }
        public decimal? ThUd2Numeric { get; set; }
        public decimal? ThUd3Numeric { get; set; }
        public decimal? ThUd4Numeric { get; set; }
        public decimal? ThUd5Numeric { get; set; }
        public DateTime? ThUd1Date { get; set; }
        public DateTime? ThUd2Date { get; set; }
        public DateTime? ThUd3Date { get; set; }
        public DateTime? ThUd4Date { get; set; }
        public DateTime? ThUd5Date { get; set; }
        public Guid? ThUd1Id { get; set; }
        public Guid? ThUd2Id { get; set; }
        public Guid? ThUd3Id { get; set; }
        public Guid? ThUd4Id { get; set; }
        public Guid? ThUd5Id { get; set; }
        public bool? ThUd1Bit { get; set; }
        public bool? ThUd2Bit { get; set; }
        public bool? ThUd3Bit { get; set; }
        public bool? ThUd4Bit { get; set; }
        public bool? ThUd5Bit { get; set; }
        public string TransactionId { get; set; }
        public string TransactionReference { get; set; }
        public string TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? TransactionDueDate { get; set; }
        public string TransactionStatus { get; set; }
        public decimal? TransactionTotal { get; set; }
        public decimal? OutstandingBalance { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string FreightMethodId { get; set; }
        public decimal? ShippingValue { get; set; }
        public decimal? ShippingTaxValue { get; set; }
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
        public string PaymentType { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingUrl { get; set; }
        public string AccountName { get; set; }
        public Guid? AccIdSales { get; set; }
        public string AcContactName { get; set; }
        public Guid? AcgId { get; set; }
        public Guid? UsIdSales { get; set; }
        public string GvAccountType { get; set; }
        public string GvContactType { get; set; }
        public string FneName { get; set; }
        public string ShortCode { get; set; }
    }
}
