using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjaNum
    {
        public Guid PjaNumId { get; set; }

        public virtual Activity PjaNumNavigation { get; set; }
    }
}
