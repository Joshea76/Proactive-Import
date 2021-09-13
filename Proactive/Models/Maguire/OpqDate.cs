using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpqDate
    {
        public Guid OpqDateId { get; set; }

        public virtual OpportunitiesQuote OpqDateNavigation { get; set; }
    }
}
