using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntNavisionTransactionHistoryLine
    {
        public Guid NavThlId { get; set; }
        public Guid NavThId { get; set; }
        public Guid ObjId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string NavThlUd1Text { get; set; }
        public string NavThlUd2Text { get; set; }
        public string NavThlUd3Text { get; set; }
        public string NavThlUd4Text { get; set; }
        public string NavThlUd5Text { get; set; }
        public decimal? NavThlUd1Numeric { get; set; }
        public decimal? NavThlUd2Numeric { get; set; }
        public decimal? NavThlUd3Numeric { get; set; }
        public decimal? NavThlUd4Numeric { get; set; }
        public decimal? NavThlUd5Numeric { get; set; }
        public DateTime? NavThlUd1Date { get; set; }
        public DateTime? NavThlUd2Date { get; set; }
        public DateTime? NavThlUd3Date { get; set; }
        public DateTime? NavThlUd4Date { get; set; }
        public DateTime? NavThlUd5Date { get; set; }
        public Guid? NavThlUd1Id { get; set; }
        public Guid? NavThlUd2Id { get; set; }
        public Guid? NavThlUd3Id { get; set; }
        public Guid? NavThlUd4Id { get; set; }
        public Guid? NavThlUd5Id { get; set; }
        public bool? NavThlUd1Bit { get; set; }
        public bool? NavThlUd2Bit { get; set; }
        public bool? NavThlUd3Bit { get; set; }
        public bool? NavThlUd4Bit { get; set; }
        public bool? NavThlUd5Bit { get; set; }
        public string NavKey { get; set; }
        public string NavType { get; set; }
        public string NavNo { get; set; }
        public string CrossReferenceNo { get; set; }
        public string IcPartnerCode { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string ReturnReasonCode { get; set; }
        public decimal? Quantity { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal? UnitCostLcy { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineAmount { get; set; }
        public decimal? LineDiscountPercent { get; set; }
        public decimal? LineDiscountAmount { get; set; }
        public bool? AllowInvoiceDisc { get; set; }
        public string JobNo { get; set; }
        public int? ApplFromItemEntry { get; set; }
        public int? ApplToItemEntry { get; set; }
        public string DeferralCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }

        public virtual IntNavisionTransactionHistory NavTh { get; set; }
        public virtual IntNavisionTransactionHistory Obj { get; set; }
    }
}
