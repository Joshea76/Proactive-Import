using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcpBit
    {
        public Guid AcpBitId { get; set; }

        public virtual AccountsProfile AcpBitNavigation { get; set; }
    }
}
