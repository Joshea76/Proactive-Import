using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VwDataErasureObject
    {
        public string Id { get; set; }
        public string Summary { get; set; }
        public DateTime? RemovalDate { get; set; }
        public int? Deleted { get; set; }
        public bool? Dormant { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
