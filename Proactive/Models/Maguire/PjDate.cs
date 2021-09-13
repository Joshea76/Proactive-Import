using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjDate
    {
        public Guid PjDateId { get; set; }

        public virtual Project PjDateNavigation { get; set; }
    }
}
