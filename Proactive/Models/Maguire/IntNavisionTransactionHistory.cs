using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntNavisionTransactionHistory
    {
        public IntNavisionTransactionHistory()
        {
            IntNavisionTransactionHistoryLineNavThs = new HashSet<IntNavisionTransactionHistoryLine>();
            IntNavisionTransactionHistoryLineObjs = new HashSet<IntNavisionTransactionHistoryLine>();
        }

        public Guid NavThId { get; set; }
        public Guid AcId { get; set; }
        public Guid ObjId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid FneId { get; set; }
        public string Source { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string NavThUd1Text { get; set; }
        public string NavThUd2Text { get; set; }
        public string NavThUd3Text { get; set; }
        public string NavThUd4Text { get; set; }
        public string NavThUd5Text { get; set; }
        public decimal? NavThUd1Numeric { get; set; }
        public decimal? NavThUd2Numeric { get; set; }
        public decimal? NavThUd3Numeric { get; set; }
        public decimal? NavThUd4Numeric { get; set; }
        public decimal? NavThUd5Numeric { get; set; }
        public DateTime? NavThUd1Date { get; set; }
        public DateTime? NavThUd2Date { get; set; }
        public DateTime? NavThUd3Date { get; set; }
        public DateTime? NavThUd4Date { get; set; }
        public DateTime? NavThUd5Date { get; set; }
        public Guid? NavThUd1Id { get; set; }
        public Guid? NavThUd2Id { get; set; }
        public Guid? NavThUd3Id { get; set; }
        public Guid? NavThUd4Id { get; set; }
        public Guid? NavThUd5Id { get; set; }
        public bool? NavThUd1Bit { get; set; }
        public bool? NavThUd2Bit { get; set; }
        public bool? NavThUd3Bit { get; set; }
        public bool? NavThUd4Bit { get; set; }
        public bool? NavThUd5Bit { get; set; }
        public string NavKey { get; set; }
        public string NavNo { get; set; }
        public string SellToContactNo { get; set; }
        public string SellToCustomerNo { get; set; }
        public string SellToCustomerName { get; set; }
        public string SellToAddress { get; set; }
        public string SellToAddress2 { get; set; }
        public string SellToCity { get; set; }
        public string SellToCounty { get; set; }
        public string SellToPostCode { get; set; }
        public string SellToContact { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentExchangeStatus { get; set; }
        public string PreAssignedNo { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string SalespersonCode { get; set; }
        public string ResponsibilityCenter { get; set; }
        public int? NoPrinted { get; set; }
        public string BillToCustomerNo { get; set; }
        public string BillToContactNo { get; set; }
        public string BillToName { get; set; }
        public string BillToAddress { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToCounty { get; set; }
        public string BillToPostCode { get; set; }
        public string BillToContact { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string PaymentMethodCode { get; set; }
        public string CreditCardNo { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToName { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCounty { get; set; }
        public string ShipToPostCode { get; set; }
        public string ShipToContact { get; set; }
        public string LocationCode { get; set; }
        public string AppliesToDocType { get; set; }
        public string AppliesToDocNo { get; set; }
        public string CurrencyCode { get; set; }
        public bool? Eu3PartyTrade { get; set; }
        public string QuoteNo { get; set; }
        public string OrderNo { get; set; }
        public string PaymentTermsCode { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? PaymentDiscountPercent { get; set; }
        public DateTime? PmtDiscountDate { get; set; }
        public string DirectDebitMandateId { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual Account Obj { get; set; }
        public virtual ICollection<IntNavisionTransactionHistoryLine> IntNavisionTransactionHistoryLineNavThs { get; set; }
        public virtual ICollection<IntNavisionTransactionHistoryLine> IntNavisionTransactionHistoryLineObjs { get; set; }
    }
}
