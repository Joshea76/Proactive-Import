using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccaBit
    {
        public Guid AccaBitId { get; set; }

        public virtual Activity AccaBitNavigation { get; set; }
    }
}
