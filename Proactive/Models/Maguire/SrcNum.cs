using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SrcNum
    {
        public Guid SrcNumId { get; set; }

        public virtual MarketingSource SrcNumNavigation { get; set; }
    }
}
