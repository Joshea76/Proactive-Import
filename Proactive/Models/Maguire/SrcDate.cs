using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SrcDate
    {
        public Guid SrcDateId { get; set; }

        public virtual MarketingSource SrcDateNavigation { get; set; }
    }
}
