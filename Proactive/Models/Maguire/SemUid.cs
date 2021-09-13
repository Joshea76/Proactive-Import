using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SemUid
    {
        public Guid SemUidId { get; set; }

        public virtual Seminar SemUidNavigation { get; set; }
    }
}
