using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpDate
    {
        public Guid OpDateId { get; set; }

        public virtual Opportunity OpDateNavigation { get; set; }
    }
}
