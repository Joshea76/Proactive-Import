using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcpUid
    {
        public Guid AcpUidId { get; set; }

        public virtual AccountsProfile AcpUidNavigation { get; set; }
    }
}
