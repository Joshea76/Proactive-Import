using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpqNum
    {
        public Guid OpqNumId { get; set; }

        public virtual OpportunitiesQuote OpqNumNavigation { get; set; }
    }
}
