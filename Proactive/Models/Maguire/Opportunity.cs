using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Opportunity
    {
        public Opportunity()
        {
            Agreements = new HashSet<Agreement>();
            OpportunitiesQuotes = new HashSet<OpportunitiesQuote>();
            OpportunitiesQuotesDetails = new HashSet<OpportunitiesQuotesDetail>();
            TimeUnitsRecords = new HashSet<TimeUnitsRecord>();
        }

        public Guid AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid OpId { get; set; }
        public bool OpDeleted { get; set; }
        public int? OpNumber { get; set; }
        public Guid? Owner { get; set; }
        public Guid? Stage { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? EstimatedClose { get; set; }
        public DateTime? ActualClose { get; set; }
        public Guid? InterestedIn { get; set; }
        public decimal PotentialValue { get; set; }
        public decimal Probability { get; set; }
        public decimal ForecastValue { get; set; }
        public bool? AddToForecast { get; set; }
        public decimal Duration { get; set; }
        public Guid? Source { get; set; }
        public string Type { get; set; }
        public string Partner { get; set; }
        public string Competition { get; set; }
        public string NextAction { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string OpUd1 { get; set; }
        public string OpUd2 { get; set; }
        public string OpUd3 { get; set; }
        public string OpUd4 { get; set; }
        public string OpUd5 { get; set; }
        public string OpUd6 { get; set; }
        public string OpUd7 { get; set; }
        public string OpUd8 { get; set; }
        public string OpUd9 { get; set; }
        public string OpUd10 { get; set; }
        public string OpUd11 { get; set; }
        public string OpUd12 { get; set; }
        public string OpUd13 { get; set; }
        public string OpUd14 { get; set; }
        public string OpUd15 { get; set; }
        public Guid? OpUd1Id { get; set; }
        public Guid? OpUd2Id { get; set; }
        public Guid? OpUd3Id { get; set; }
        public Guid? OpUd4Id { get; set; }
        public Guid? OpUd5Id { get; set; }
        public Guid? OpUd6Id { get; set; }
        public Guid? OpUd7Id { get; set; }
        public Guid? OpUd8Id { get; set; }
        public Guid? OpUd9Id { get; set; }
        public Guid? OpUd10Id { get; set; }
        public DateTime? OpUd1Date { get; set; }
        public DateTime? OpUd2Date { get; set; }
        public DateTime? OpUd3Date { get; set; }
        public DateTime? OpUd4Date { get; set; }
        public DateTime? OpUd5Date { get; set; }
        public DateTime? OpUd6Date { get; set; }
        public DateTime? OpUd7Date { get; set; }
        public DateTime? OpUd8Date { get; set; }
        public DateTime? OpUd9Date { get; set; }
        public DateTime? OpUd10Date { get; set; }
        public bool? OpUd1Bit { get; set; }
        public bool? OpUd2Bit { get; set; }
        public bool? OpUd3Bit { get; set; }
        public bool? OpUd4Bit { get; set; }
        public bool? OpUd5Bit { get; set; }
        public bool? OpUd6Bit { get; set; }
        public bool? OpUd7Bit { get; set; }
        public bool? OpUd8Bit { get; set; }
        public bool? OpUd9Bit { get; set; }
        public bool? OpUd10Bit { get; set; }
        public decimal? OpUd1Numeric { get; set; }
        public decimal? OpUd2Numeric { get; set; }
        public decimal? OpUd3Numeric { get; set; }
        public decimal? OpUd4Numeric { get; set; }
        public decimal? OpUd5Numeric { get; set; }
        public decimal? OpUd6Numeric { get; set; }
        public decimal? OpUd7Numeric { get; set; }
        public decimal? OpUd8Numeric { get; set; }
        public decimal? OpUd9Numeric { get; set; }
        public decimal? OpUd10Numeric { get; set; }
        public string OpExternal { get; set; }
        public decimal? Margin { get; set; }
        public decimal? MarginPercentage { get; set; }
        public string Reference { get; set; }
        public bool? OpUd11Bit { get; set; }
        public bool? OpUd12Bit { get; set; }
        public bool? OpUd13Bit { get; set; }
        public bool? OpUd14Bit { get; set; }
        public bool? OpUd15Bit { get; set; }
        public bool? OpUd16Bit { get; set; }
        public bool? OpUd17Bit { get; set; }
        public bool? OpUd18Bit { get; set; }
        public bool? OpUd19Bit { get; set; }
        public bool? OpUd20Bit { get; set; }
        public bool? OpUd21Bit { get; set; }
        public bool? OpUd22Bit { get; set; }
        public bool? OpUd23Bit { get; set; }
        public bool? OpUd24Bit { get; set; }
        public Guid? MacIdSource { get; set; }
        public byte? OpState { get; set; }
        public Guid? CurId { get; set; }
        public Guid? OpImport { get; set; }
        public Guid? StgId { get; set; }
        public Guid? SgId { get; set; }
        public int ShortCode { get; set; }
        public bool? Closed { get; set; }
        public int EstimatedUnits { get; set; }
        public int EstimatedTime { get; set; }
        public int ActualUnits { get; set; }
        public int ActualTime { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid? SitId { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual MailCampaign MacIdSourceNavigation { get; set; }
        public virtual User OwnerNavigation { get; set; }
        public virtual OpBit OpBit { get; set; }
        public virtual OpDate OpDate { get; set; }
        public virtual OpNum OpNum { get; set; }
        public virtual OpTxt OpTxt { get; set; }
        public virtual OpUid OpUid { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<OpportunitiesQuote> OpportunitiesQuotes { get; set; }
        public virtual ICollection<OpportunitiesQuotesDetail> OpportunitiesQuotesDetails { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecords { get; set; }
    }
}
