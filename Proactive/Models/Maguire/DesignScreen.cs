using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignScreen
    {
        public DesignScreen()
        {
            DesignEntities = new HashSet<DesignEntity>();
            DesignScreenPages = new HashSet<DesignScreenPage>();
            GlobalSearchFields = new HashSet<GlobalSearchField>();
        }

        public Guid DscId { get; set; }
        public Guid? DstId { get; set; }
        public Guid? LegId { get; set; }
        public bool IsEditable { get; set; }
        public bool PrimaryScreen { get; set; }
        public bool? AvatarsEnabled { get; set; }
        public bool GloballySearchable { get; set; }
        public bool? IsOnNewMenu { get; set; }
        public bool DuplicateCheckEnabled { get; set; }
        public string ShortCodePrefix { get; set; }

        public virtual DesignSet Dst { get; set; }
        public virtual ICollection<DesignEntity> DesignEntities { get; set; }
        public virtual ICollection<DesignScreenPage> DesignScreenPages { get; set; }
        public virtual ICollection<GlobalSearchField> GlobalSearchFields { get; set; }
    }
}
