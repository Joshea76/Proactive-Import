using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcaBit
    {
        public Guid AcaBitId { get; set; }

        public virtual Activity AcaBitNavigation { get; set; }
    }
}
