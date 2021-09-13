using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyChildField
    {
        public Guid DlccId { get; set; }
        public Guid DlcId { get; set; }
        public Guid LfdIdParent { get; set; }
        public Guid LfdIdChild { get; set; }

        public virtual DesignLegacyChild Dlc { get; set; }
        public virtual DesignLegacyField LfdIdChildNavigation { get; set; }
        public virtual DesignLegacyField LfdIdParentNavigation { get; set; }
    }
}
