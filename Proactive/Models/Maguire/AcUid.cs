using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcUid
    {
        public Guid AcUidId { get; set; }
        public Guid? AcUid1 { get; set; }
        public Guid? AcUid2 { get; set; }

        public virtual Account AcUidNavigation { get; set; }
    }
}
