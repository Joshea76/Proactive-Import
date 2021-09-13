using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignList
    {
        public DesignList()
        {
            DesignEntities = new HashSet<DesignEntity>();
            DesignListColumns = new HashSet<DesignListColumn>();
            DesignListFields = new HashSet<DesignListField>();
            DesignSubLists = new HashSet<DesignSubList>();
        }

        public Guid DltId { get; set; }
        public Guid? DstId { get; set; }
        public Guid? LegId { get; set; }
        public short? DefaultView { get; set; }
        public Guid? DefaultDscId { get; set; }
        public bool CanExpandToEdit { get; set; }
        public bool CanNotesDigestForReports { get; set; }
        public string ListPrefix { get; set; }

        public virtual DesignSet Dst { get; set; }
        public virtual ICollection<DesignEntity> DesignEntities { get; set; }
        public virtual ICollection<DesignListColumn> DesignListColumns { get; set; }
        public virtual ICollection<DesignListField> DesignListFields { get; set; }
        public virtual ICollection<DesignSubList> DesignSubLists { get; set; }
    }
}
