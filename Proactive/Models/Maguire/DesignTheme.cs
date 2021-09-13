using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignTheme
    {
        public Guid LegId { get; set; }
        public Guid DstId { get; set; }
        public byte Color { get; set; }
        public string Icon { get; set; }

        public virtual DesignSet Dst { get; set; }
        public virtual DesignLegacyFile Leg { get; set; }
    }
}
