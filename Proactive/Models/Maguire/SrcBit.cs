using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SrcBit
    {
        public Guid SrcBitId { get; set; }

        public virtual MarketingSource SrcBitNavigation { get; set; }
    }
}
