using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccBit
    {
        public Guid AccBitId { get; set; }

        public virtual AccountsContact AccBitNavigation { get; set; }
    }
}
