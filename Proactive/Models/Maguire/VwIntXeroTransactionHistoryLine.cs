using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwIntXeroTransactionHistoryLine
    {
        public Guid XeroThlId { get; set; }
        public Guid XeroThId { get; set; }
        public Guid ObjId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public string XeroThlUd1Text { get; set; }
        public string XeroThlUd2Text { get; set; }
        public string XeroThlUd3Text { get; set; }
        public string XeroThlUd4Text { get; set; }
        public string XeroThlUd5Text { get; set; }
        public decimal? XeroThlUd1Numeric { get; set; }
        public decimal? XeroThlUd2Numeric { get; set; }
        public decimal? XeroThlUd3Numeric { get; set; }
        public decimal? XeroThlUd4Numeric { get; set; }
        public decimal? XeroThlUd5Numeric { get; set; }
        public DateTime? XeroThlUd1Date { get; set; }
        public DateTime? XeroThlUd2Date { get; set; }
        public DateTime? XeroThlUd3Date { get; set; }
        public DateTime? XeroThlUd4Date { get; set; }
        public DateTime? XeroThlUd5Date { get; set; }
        public Guid? XeroThlUd1Id { get; set; }
        public Guid? XeroThlUd2Id { get; set; }
        public Guid? XeroThlUd3Id { get; set; }
        public Guid? XeroThlUd4Id { get; set; }
        public Guid? XeroThlUd5Id { get; set; }
        public bool? XeroThlUd1Bit { get; set; }
        public bool? XeroThlUd2Bit { get; set; }
        public bool? XeroThlUd3Bit { get; set; }
        public bool? XeroThlUd4Bit { get; set; }
        public bool? XeroThlUd5Bit { get; set; }
        public string ItemCode { get; set; }
        public string LineItemId { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitAmount { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string TaxType { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? LineAmount { get; set; }
        public string AccountCode { get; set; }
        public string ShortCode { get; set; }
        public Guid ParentXeroId { get; set; }
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
    }
}
