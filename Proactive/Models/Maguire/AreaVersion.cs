using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AreaVersion
    {
        public int VersionId { get; set; }
        public Guid AreaId { get; set; }
        public Guid SpaceId { get; set; }
        public string AreaName { get; set; }
        public int Type { get; set; }
        public bool IsHidden { get; set; }
    }
}
