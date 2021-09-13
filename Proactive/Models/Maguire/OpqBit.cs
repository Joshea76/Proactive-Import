using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpqBit
    {
        public Guid OpqBitId { get; set; }

        public virtual OpportunitiesQuote OpqBitNavigation { get; set; }
    }
}
