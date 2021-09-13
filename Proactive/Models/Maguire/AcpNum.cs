using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcpNum
    {
        public Guid AcpNumId { get; set; }

        public virtual AccountsProfile AcpNumNavigation { get; set; }
    }
}
