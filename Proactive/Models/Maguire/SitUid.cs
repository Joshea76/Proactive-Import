using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SitUid
    {
        public Guid SitUidId { get; set; }

        public virtual Site SitUidNavigation { get; set; }
    }
}
