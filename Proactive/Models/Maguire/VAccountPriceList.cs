using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAccountPriceList
    {
        public Guid AcurId { get; set; }
        public bool IsDefault { get; set; }
        public Guid AcId { get; set; }
        public Guid CurId { get; set; }
        public bool? CurDeleted { get; set; }
        public string Summary { get; set; }
        public string Symbol { get; set; }
        public double BaseExchange { get; set; }
        public int? Order { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string CurExternal { get; set; }
        public string Code { get; set; }
        public bool PriceList { get; set; }
        public double Discount { get; set; }
        public Guid? TxcId { get; set; }
        public bool? Exclusive { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? FneId { get; set; }
        public string ShortCode { get; set; }
    }
}
