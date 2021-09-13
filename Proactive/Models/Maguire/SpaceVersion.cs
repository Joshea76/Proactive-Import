using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SpaceVersion
    {
        public int VersionId { get; set; }
        public Guid SpaceId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        public virtual Space Space { get; set; }
    }
}
