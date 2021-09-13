using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignMenuGroupItemOrder
    {
        public Guid LegId { get; set; }
        public Guid? GroupId { get; set; }
        public int? ItemOrder { get; set; }

        public virtual DesignMenuGroup Group { get; set; }
        public virtual DesignLegacyFile Leg { get; set; }
    }
}
