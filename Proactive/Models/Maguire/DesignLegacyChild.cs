using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyChild
    {
        public DesignLegacyChild()
        {
            DesignLegacyChildFields = new HashSet<DesignLegacyChildField>();
        }

        public Guid DlcId { get; set; }
        public Guid LegIdParent { get; set; }
        public Guid LegIdChild { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsCustom { get; set; }
        public bool? IsHorizontal { get; set; }
        public bool IsWhatsnext { get; set; }

        public virtual DesignLegacyFile LegIdChildNavigation { get; set; }
        public virtual DesignLegacyFile LegIdParentNavigation { get; set; }
        public virtual ICollection<DesignLegacyChildField> DesignLegacyChildFields { get; set; }
    }
}
