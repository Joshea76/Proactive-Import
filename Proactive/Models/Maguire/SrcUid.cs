using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SrcUid
    {
        public Guid SrcUidId { get; set; }

        public virtual MarketingSource SrcUidNavigation { get; set; }
    }
}
