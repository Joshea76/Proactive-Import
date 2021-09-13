using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsProduct
    {
        public Guid SemId { get; set; }
        public Guid? PrId { get; set; }
        public Guid SemprId { get; set; }
        public decimal Quantity { get; set; }
        public bool? EarlyBirdDiscountable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Code { get; set; }
        public string ProductGroup { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public double? Discount { get; set; }
        public decimal? PriceDiscount { get; set; }
        public decimal? PriceFinal { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? Cost { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }

        public virtual Product Pr { get; set; }
        public virtual Seminar Sem { get; set; }
    }
}
