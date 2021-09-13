using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SitBit
    {
        public Guid SitBitId { get; set; }

        public virtual Site SitBitNavigation { get; set; }
    }
}
