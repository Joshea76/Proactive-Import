using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcDate
    {
        public Guid AcDateId { get; set; }

        public virtual Account AcDateNavigation { get; set; }
    }
}
