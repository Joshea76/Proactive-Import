using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntWinmanTransactionHistoryLine
    {
        public Guid WinThlId { get; set; }
        public Guid WinThId { get; set; }
        public Guid ObjId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string WinThlUd1Text { get; set; }
        public string WinThlUd2Text { get; set; }
        public string WinThlUd3Text { get; set; }
        public string WinThlUd4Text { get; set; }
        public string WinThlUd5Text { get; set; }
        public decimal? WinThlUd1Numeric { get; set; }
        public decimal? WinThlUd2Numeric { get; set; }
        public decimal? WinThlUd3Numeric { get; set; }
        public decimal? WinThlUd4Numeric { get; set; }
        public decimal? WinThlUd5Numeric { get; set; }
        public DateTime? WinThlUd1Date { get; set; }
        public DateTime? WinThlUd2Date { get; set; }
        public DateTime? WinThlUd3Date { get; set; }
        public DateTime? WinThlUd4Date { get; set; }
        public DateTime? WinThlUd5Date { get; set; }
        public Guid? WinThlUd1Id { get; set; }
        public Guid? WinThlUd2Id { get; set; }
        public Guid? WinThlUd3Id { get; set; }
        public Guid? WinThlUd4Id { get; set; }
        public Guid? WinThlUd5Id { get; set; }
        public bool? WinThlUd1Bit { get; set; }
        public bool? WinThlUd2Bit { get; set; }
        public bool? WinThlUd3Bit { get; set; }
        public bool? WinThlUd4Bit { get; set; }
        public bool? WinThlUd5Bit { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
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
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual IntWinManTransactionHistory WinTh { get; set; }
    }
}
