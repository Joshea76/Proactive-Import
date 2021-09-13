using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpaBit
    {
        public Guid OpaBitId { get; set; }

        public virtual Activity OpaBitNavigation { get; set; }
    }
}
