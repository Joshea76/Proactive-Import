using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignScreenFieldGroup
    {
        public DesignScreenFieldGroup()
        {
            DesignFieldGroupFieldLinks = new HashSet<DesignFieldGroupFieldLink>();
        }

        public Guid DsfgId { get; set; }
        public Guid DspsId { get; set; }
        public short? FieldGroupOrdinal { get; set; }
        public int FieldGroupWidth { get; set; }
        public int? AccessRights { get; set; }

        public virtual DesignScreenPageSection Dsps { get; set; }
        public virtual ICollection<DesignFieldGroupFieldLink> DesignFieldGroupFieldLinks { get; set; }
    }
}
