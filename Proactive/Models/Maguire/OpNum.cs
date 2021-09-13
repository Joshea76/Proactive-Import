using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class OpNum
    {
        public Guid OpNumId { get; set; }

        public virtual Opportunity OpNumNavigation { get; set; }
    }
}
