using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ComponentVersion
    {
        public int VersionId { get; set; }
        public Guid SpaceId { get; set; }
        public Guid ComId { get; set; }
        public Guid AreaId { get; set; }
        public string Summary { get; set; }
        public int Type { get; set; }
        public short Order { get; set; }

        public virtual Space Space { get; set; }
    }
}
