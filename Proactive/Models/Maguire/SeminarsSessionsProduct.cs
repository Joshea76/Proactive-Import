using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsSessionsProduct
    {
        public SeminarsSessionsProduct()
        {
            SeminarsBookingsProducts = new HashSet<SeminarsBookingsProduct>();
        }

        public Guid SemId { get; set; }
        public Guid SemsId { get; set; }
        public Guid? PrId { get; set; }
        public Guid SemsprId { get; set; }
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
        public string ExternalEventbriteId { get; set; }
        public bool? IsEventbriteTicket { get; set; }

        public virtual Product Pr { get; set; }
        public virtual Seminar Sem { get; set; }
        public virtual SeminarsSession Sems { get; set; }
        public virtual ICollection<SeminarsBookingsProduct> SeminarsBookingsProducts { get; set; }
    }
}
