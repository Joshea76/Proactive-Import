using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjNum
    {
        public Guid PjNumId { get; set; }

        public virtual Project PjNumNavigation { get; set; }
    }
}
