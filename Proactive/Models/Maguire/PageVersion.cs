using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PageVersion
    {
        public Guid SpaceId { get; set; }
        public int VersionId { get; set; }
        public Guid PageId { get; set; }
        public string PageName { get; set; }
        public Guid AreaId { get; set; }
        public string JsonPayload { get; set; }
        public bool IsHidden { get; set; }
    }
}
