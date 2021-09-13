using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ProductsCurrency
    {
        public Guid PrcId { get; set; }
        public Guid CurId { get; set; }
        public Guid PrId { get; set; }
        public decimal Price { get; set; }
        public bool? PrcDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? TxcIdFixed { get; set; }
        public double? FixedDiscountRate { get; set; }
        public decimal? Cost { get; set; }

        public virtual Currency Cur { get; set; }
        public virtual Product Pr { get; set; }
    }
}
