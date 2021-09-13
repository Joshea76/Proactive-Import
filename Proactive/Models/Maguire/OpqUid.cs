using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpqUid
    {
        public Guid OpqUidId { get; set; }

        public virtual OpportunitiesQuote OpqUidNavigation { get; set; }
    }
}
