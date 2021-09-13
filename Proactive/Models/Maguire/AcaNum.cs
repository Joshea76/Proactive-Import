using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcaNum
    {
        public Guid AcaNumId { get; set; }

        public virtual Activity AcaNumNavigation { get; set; }
    }
}
