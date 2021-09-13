using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjaBit
    {
        public Guid PjaBitId { get; set; }

        public virtual Activity PjaBitNavigation { get; set; }
    }
}
