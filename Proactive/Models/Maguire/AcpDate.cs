using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcpDate
    {
        public Guid AcpDateId { get; set; }

        public virtual AccountsProfile AcpDateNavigation { get; set; }
    }
}
