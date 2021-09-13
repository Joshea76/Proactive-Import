using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjaTxt
    {
        public Guid PjaTxtId { get; set; }

        public virtual Activity PjaTxtNavigation { get; set; }
    }
}
