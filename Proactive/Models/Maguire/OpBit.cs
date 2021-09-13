using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpBit
    {
        public Guid OpBitId { get; set; }

        public virtual Opportunity OpBitNavigation { get; set; }
    }
}
