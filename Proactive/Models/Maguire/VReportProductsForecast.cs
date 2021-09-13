using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VReportProductsForecast
    {
        public string Product { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceDiscount { get; set; }
        public decimal? PriceFinal { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? EstimatedClose { get; set; }
        public DateTime? ActualClose { get; set; }
        public bool? AddToOpportunity { get; set; }
        public string Code { get; set; }
        public bool? AddToForecast { get; set; }
        public bool OpDeleted { get; set; }
        public bool? OpqDeleted { get; set; }
        public bool? OpqdDeleted { get; set; }
        public Guid? PrgId { get; set; }
        public string ProductGroup { get; set; }
        public decimal? Cost { get; set; }
        public Guid? PrId { get; set; }
        public string AcName { get; set; }
        public double? Discount { get; set; }
        public string Opportunity { get; set; }
        public Guid AcId { get; set; }
    }
}
