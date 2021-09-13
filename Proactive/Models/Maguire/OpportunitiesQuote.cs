using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpportunitiesQuote
    {
        public OpportunitiesQuote()
        {
            Agreements = new HashSet<Agreement>();
            IntAnagramDespatches = new HashSet<IntAnagramDespatch>();
            OpportunitiesQuotesDetails = new HashSet<OpportunitiesQuotesDetail>();
        }

        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? OpId { get; set; }
        public Guid OpqId { get; set; }
        public bool? OpqDeleted { get; set; }
        public Guid? OpqType { get; set; }
        public string OpqNumber { get; set; }
        public string Reference { get; set; }
        public string Template { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public decimal? Value { get; set; }
        public string SentStatus { get; set; }
        public DateTime? Expires { get; set; }
        public double NumberOfItems { get; set; }
        public decimal CostItems { get; set; }
        public double DiscountItems { get; set; }
        public decimal CostQuote { get; set; }
        public double DiscountAccount { get; set; }
        public decimal CostSub { get; set; }
        public decimal CostCarriage { get; set; }
        public decimal CostMisc { get; set; }
        public decimal CostUpdatedSub { get; set; }
        public decimal CostVat { get; set; }
        public decimal CostTotal { get; set; }
        public bool? AddToOpportunity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string OpqUd1 { get; set; }
        public string OpqUd2 { get; set; }
        public string OpqUd3 { get; set; }
        public string OpqUd4 { get; set; }
        public string OpqUd5 { get; set; }
        public string OpqUd6 { get; set; }
        public string OpqUd7 { get; set; }
        public string OpqUd8 { get; set; }
        public string OpqUd9 { get; set; }
        public string OpqUd10 { get; set; }
        public string OpqUd11 { get; set; }
        public string OpqUd12 { get; set; }
        public string OpqUd13 { get; set; }
        public string OpqUd14 { get; set; }
        public string OpqUd15 { get; set; }
        public Guid? CurId { get; set; }
        public decimal? Margin { get; set; }
        public decimal? MarginPercentage { get; set; }
        public Guid? Owner { get; set; }
        public Guid? OpqUd1Id { get; set; }
        public Guid? OpqUd2Id { get; set; }
        public Guid? OpqUd3Id { get; set; }
        public Guid? OpqUd4Id { get; set; }
        public Guid? OpqUd5Id { get; set; }
        public Guid? OpqUd6Id { get; set; }
        public Guid? OpqUd7Id { get; set; }
        public Guid? OpqUd8Id { get; set; }
        public Guid? OpqUd9Id { get; set; }
        public Guid? OpqUd10Id { get; set; }
        public DateTime? OpqUd1Date { get; set; }
        public DateTime? OpqUd2Date { get; set; }
        public DateTime? OpqUd3Date { get; set; }
        public DateTime? OpqUd4Date { get; set; }
        public DateTime? OpqUd5Date { get; set; }
        public DateTime? OpqUd6Date { get; set; }
        public DateTime? OpqUd7Date { get; set; }
        public DateTime? OpqUd8Date { get; set; }
        public DateTime? OpqUd9Date { get; set; }
        public DateTime? OpqUd10Date { get; set; }
        public decimal? OpqUd1Numeric { get; set; }
        public decimal? OpqUd2Numeric { get; set; }
        public decimal? OpqUd3Numeric { get; set; }
        public decimal? OpqUd4Numeric { get; set; }
        public decimal? OpqUd5Numeric { get; set; }
        public decimal? OpqUd6Numeric { get; set; }
        public decimal? OpqUd7Numeric { get; set; }
        public decimal? OpqUd8Numeric { get; set; }
        public decimal? OpqUd9Numeric { get; set; }
        public decimal? OpqUd10Numeric { get; set; }
        public bool? OpqUd1Bit { get; set; }
        public bool? OpqUd2Bit { get; set; }
        public bool? OpqUd3Bit { get; set; }
        public bool? OpqUd4Bit { get; set; }
        public bool? OpqUd5Bit { get; set; }
        public bool? OpqUd6Bit { get; set; }
        public bool? OpqUd7Bit { get; set; }
        public bool? OpqUd8Bit { get; set; }
        public bool? OpqUd9Bit { get; set; }
        public bool? OpqUd10Bit { get; set; }
        public bool? OpqUd11Bit { get; set; }
        public bool? OpqUd12Bit { get; set; }
        public bool? OpqUd13Bit { get; set; }
        public bool? OpqUd14Bit { get; set; }
        public bool? OpqUd15Bit { get; set; }
        public bool? OpqUd16Bit { get; set; }
        public bool? OpqUd17Bit { get; set; }
        public bool? OpqUd18Bit { get; set; }
        public bool? OpqUd19Bit { get; set; }
        public bool? OpqUd20Bit { get; set; }
        public bool? OpqUd21Bit { get; set; }
        public bool? OpqUd22Bit { get; set; }
        public bool? OpqUd23Bit { get; set; }
        public bool? OpqUd24Bit { get; set; }
        public byte? OpqState { get; set; }
        public bool? ForcedClose { get; set; }
        public DateTime? ActualClose { get; set; }
        public Guid? CurIdPriceList { get; set; }
        public DateTime? EstimatedClose { get; set; }
        public Guid? FneId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public Guid? SitId { get; set; }
        public int ShortCode { get; set; }
        public bool? Closed { get; set; }
        public bool? Scheduled { get; set; }
        public int TimeTotal { get; set; }
        public int UnitsTotal { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual FinancialEntity Fne { get; set; }
        public virtual Opportunity Op { get; set; }
        public virtual OpqBit OpqBit { get; set; }
        public virtual OpqDate OpqDate { get; set; }
        public virtual OpqNum OpqNum { get; set; }
        public virtual OpqTxt OpqTxt { get; set; }
        public virtual OpqUid OpqUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<IntAnagramDespatch> IntAnagramDespatches { get; set; }
        public virtual ICollection<OpportunitiesQuotesDetail> OpportunitiesQuotesDetails { get; set; }
    }
}
