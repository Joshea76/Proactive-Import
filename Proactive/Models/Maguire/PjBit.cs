using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjBit
    {
        public Guid PjBitId { get; set; }

        public virtual Project PjBitNavigation { get; set; }
    }
}
