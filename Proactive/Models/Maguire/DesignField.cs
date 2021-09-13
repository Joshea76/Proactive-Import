using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignField
    {
        public DesignField()
        {
            DesignFieldGroupFieldLinks = new HashSet<DesignFieldGroupFieldLink>();
            DesignListColumns = new HashSet<DesignListColumn>();
            DesignListFields = new HashSet<DesignListField>();
        }

        public Guid DfdId { get; set; }
        public Guid? LfdId { get; set; }
        public Guid? ActionDscId { get; set; }
        public Guid? PickerDltId { get; set; }
        public short DisplayType2 { get; set; }
        public bool ReadOnly { get; set; }
        public Guid? ParentLfdId { get; set; }
        public byte? MandatoryType { get; set; }
        public byte? DeDupeType { get; set; }
        public Guid? AncestorDscId { get; set; }
        public Guid? NewitemPickerDltId { get; set; }

        public virtual DesignLegacyField Lfd { get; set; }
        public virtual ICollection<DesignFieldGroupFieldLink> DesignFieldGroupFieldLinks { get; set; }
        public virtual ICollection<DesignListColumn> DesignListColumns { get; set; }
        public virtual ICollection<DesignListField> DesignListFields { get; set; }
    }
}
