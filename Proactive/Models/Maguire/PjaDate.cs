using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjaDate
    {
        public Guid PjaDateId { get; set; }

        public virtual Activity PjaDateNavigation { get; set; }
    }
}
