using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpaTxt
    {
        public Guid OpaTxtId { get; set; }

        public virtual Activity OpaTxtNavigation { get; set; }
    }
}
