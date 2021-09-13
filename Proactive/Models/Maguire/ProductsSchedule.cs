using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ProductsSchedule
    {
        public Guid PrsId { get; set; }
        public Guid PrId { get; set; }
        public int? Month { get; set; }
        public decimal? Percent { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Product Pr { get; set; }
    }
}
