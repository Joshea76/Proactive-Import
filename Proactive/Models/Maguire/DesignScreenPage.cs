using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignScreenPage
    {
        public DesignScreenPage()
        {
            DesignScreenPageSections = new HashSet<DesignScreenPageSection>();
        }

        public Guid DspId { get; set; }
        public Guid DscId { get; set; }
        public short? PageOrdinal { get; set; }
        public int AccessRights { get; set; }
        public bool? IsFixed { get; set; }

        public virtual DesignScreen Dsc { get; set; }
        public virtual ICollection<DesignScreenPageSection> DesignScreenPageSections { get; set; }
    }
}
