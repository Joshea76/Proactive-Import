using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcaUid
    {
        public Guid AcaUidId { get; set; }

        public virtual Activity AcaUidNavigation { get; set; }
    }
}
