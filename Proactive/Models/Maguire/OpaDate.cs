using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpaDate
    {
        public Guid OpaDateId { get; set; }

        public virtual Activity OpaDateNavigation { get; set; }
    }
}
