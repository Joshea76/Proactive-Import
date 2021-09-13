using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwIntAccountingTransactionHistoryLine
    {
        public Guid ThlId { get; set; }
        public Guid ThId { get; set; }
        public Guid ObjId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string ThlUd1Text { get; set; }
        public string ThlUd2Text { get; set; }
        public string ThlUd3Text { get; set; }
        public string ThlUd4Text { get; set; }
        public string ThlUd5Text { get; set; }
        public decimal? ThlUd1Numeric { get; set; }
        public decimal? ThlUd2Numeric { get; set; }
        public decimal? ThlUd3Numeric { get; set; }
        public decimal? ThlUd4Numeric { get; set; }
        public decimal? ThlUd5Numeric { get; set; }
        public DateTime? ThlUd1Date { get; set; }
        public DateTime? ThlUd2Date { get; set; }
        public DateTime? ThlUd3Date { get; set; }
        public DateTime? ThlUd4Date { get; set; }
        public DateTime? ThlUd5Date { get; set; }
        public Guid? ThlUd1Id { get; set; }
        public Guid? ThlUd2Id { get; set; }
        public Guid? ThlUd3Id { get; set; }
        public Guid? ThlUd4Id { get; set; }
        public Guid? ThlUd5Id { get; set; }
        public bool? ThlUd1Bit { get; set; }
        public bool? ThlUd2Bit { get; set; }
        public bool? ThlUd3Bit { get; set; }
        public bool? ThlUd4Bit { get; set; }
        public bool? ThlUd5Bit { get; set; }
        public string Sku { get; set; }
        public string Summary { get; set; }
        public string FreightMethodId { get; set; }
        public string SundryId { get; set; }
        public string FreeTextItem { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? LineValue { get; set; }
        public decimal? LineTaxValue { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string Source { get; set; }
        public string ParentSummary { get; set; }
        public string AccountName { get; set; }
        public Guid AcId { get; set; }
        public string AcContactName { get; set; }
        public Guid? AccIdSales { get; set; }
        public Guid? AcgId { get; set; }
        public Guid? UsIdSales { get; set; }
        public string GvAccountType { get; set; }
        public string GvContactType { get; set; }
        public string FneName { get; set; }
        public Guid FneId { get; set; }
        public string ShortCode { get; set; }
    }
}
