using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpportunitiesQuotesDetail
    {
        public OpportunitiesQuotesDetail()
        {
            TimeUnitsRecords = new HashSet<TimeUnitsRecord>();
        }

        public Guid? AcId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? OpqId { get; set; }
        public Guid? PrId { get; set; }
        public Guid OpqdId { get; set; }
        public bool? OpqdDeleted { get; set; }
        public string Code { get; set; }
        public string ProductGroup { get; set; }
        public string Manufacturer { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public decimal PriceDiscount { get; set; }
        public decimal PriceFinal { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
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
        public decimal? TaxPercentage { get; set; }
        public decimal? Cost { get; set; }
        public int? SortOrder { get; set; }
        public Guid? PrUd1Id { get; set; }
        public Guid? PrUd2Id { get; set; }
        public Guid? PrUd3Id { get; set; }
        public Guid? PrUd4Id { get; set; }
        public Guid? PrUd5Id { get; set; }
        public Guid? PrUd6Id { get; set; }
        public Guid? PrUd7Id { get; set; }
        public Guid? PrUd8Id { get; set; }
        public Guid? PrUd9Id { get; set; }
        public Guid? PrUd10Id { get; set; }
        public DateTime? PrUd1Date { get; set; }
        public DateTime? PrUd2Date { get; set; }
        public DateTime? PrUd3Date { get; set; }
        public DateTime? PrUd4Date { get; set; }
        public DateTime? PrUd5Date { get; set; }
        public DateTime? PrUd6Date { get; set; }
        public DateTime? PrUd7Date { get; set; }
        public DateTime? PrUd8Date { get; set; }
        public DateTime? PrUd9Date { get; set; }
        public DateTime? PrUd10Date { get; set; }
        public bool? PrUd1Bit { get; set; }
        public bool? PrUd2Bit { get; set; }
        public bool? PrUd3Bit { get; set; }
        public bool? PrUd4Bit { get; set; }
        public bool? PrUd5Bit { get; set; }
        public bool? PrUd6Bit { get; set; }
        public bool? PrUd7Bit { get; set; }
        public bool? PrUd8Bit { get; set; }
        public bool? PrUd9Bit { get; set; }
        public bool? PrUd10Bit { get; set; }
        public decimal? PrUd1Numeric { get; set; }
        public decimal? PrUd2Numeric { get; set; }
        public decimal? PrUd3Numeric { get; set; }
        public decimal? PrUd4Numeric { get; set; }
        public decimal? PrUd5Numeric { get; set; }
        public decimal? PrUd6Numeric { get; set; }
        public decimal? PrUd7Numeric { get; set; }
        public decimal? PrUd8Numeric { get; set; }
        public decimal? PrUd9Numeric { get; set; }
        public decimal? PrUd10Numeric { get; set; }
        public bool? Excludefromtotal { get; set; }
        public double? RateWhenAdded { get; set; }
        public int ShortCode { get; set; }
        public decimal? AccountDiscount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? ListPriceTotal { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public bool? Closed { get; set; }
        public Guid? TxcId { get; set; }
        public decimal? PrUd11Numeric { get; set; }
        public decimal? PrUd12Numeric { get; set; }
        public decimal? PrUd13Numeric { get; set; }
        public decimal? PrUd14NumeriC { get; set; }
        public decimal? PrUd15Numeric { get; set; }
        public int TimeUnitValue { get; set; }
        public bool? TimeUnitIsTime { get; set; }
        public int TimeUnitValueTotal { get; set; }
        public int SpentTimeUnits { get; set; }
        public string ShortCodePrefix { get; set; }
        public int? RemainingTimeUnits { get; set; }
        public string PrefixedShortCode { get; set; }
        public string PrExternal { get; set; }

        public virtual Account Ac { get; set; }
        public virtual Opportunity Op { get; set; }
        public virtual OpportunitiesQuote Opq { get; set; }
        public virtual Product Pr { get; set; }
        public virtual TaxCode Txc { get; set; }
        public virtual ICollection<TimeUnitsRecord> TimeUnitsRecords { get; set; }
    }
}
