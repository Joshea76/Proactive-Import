using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpaUid
    {
        public Guid OpaUidId { get; set; }

        public virtual Activity OpaUidNavigation { get; set; }
    }
}
