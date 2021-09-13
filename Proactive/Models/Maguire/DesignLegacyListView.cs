using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyListView
    {
        public Guid LegId { get; set; }
        public short ListViewType { get; set; }

        public virtual DesignLegacyFile Leg { get; set; }
    }
}
