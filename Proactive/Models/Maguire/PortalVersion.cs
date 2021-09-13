using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PortalVersion
    {
        public int VersionId { get; set; }
        public int VersionNumber { get; set; }
        public Guid SpaceId { get; set; }
        public Guid PublishedByUsId { get; set; }
        public bool IsLatestVersion { get; set; }

        public virtual User PublishedByUs { get; set; }
    }
}
