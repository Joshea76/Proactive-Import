using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VPriceListsSelect
    {
        public string Summary { get; set; }
        public double? Discount { get; set; }
        public Guid CurId { get; set; }
        public int CurOrder { get; set; }
    }
}
