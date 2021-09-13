using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcaTxt
    {
        public Guid AcaTxtId { get; set; }

        public virtual Activity AcaTxtNavigation { get; set; }
    }
}
