using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacySubList
    {
        public Guid ObjectLegId { get; set; }
        public Guid ListLegId { get; set; }
        public string ParentField { get; set; }

        public virtual DesignLegacyFile ListLeg { get; set; }
        public virtual DesignLegacyFile ObjectLeg { get; set; }
    }
}
