using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PjaUid
    {
        public Guid PjaUidId { get; set; }

        public virtual Activity PjaUidNavigation { get; set; }
    }
}
