using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcBit
    {
        public Guid AcBitId { get; set; }

        public virtual Account AcBitNavigation { get; set; }
    }
}
