using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpUid
    {
        public Guid OpUidId { get; set; }

        public virtual Opportunity OpUidNavigation { get; set; }
    }
}
