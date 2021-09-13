using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjUid
    {
        public Guid PjUidId { get; set; }

        public virtual Project PjUidNavigation { get; set; }
    }
}
