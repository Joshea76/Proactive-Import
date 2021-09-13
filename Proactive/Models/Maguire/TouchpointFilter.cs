using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointFilter
    {
        public int TpfId { get; set; }
        public int TpcId { get; set; }
        public string FilterName { get; set; }
        public string FilterValue { get; set; }
        public bool IsAction { get; set; }
        public string Data1 { get; set; }

        public virtual TouchpointConfiguration Tpc { get; set; }
    }
}
