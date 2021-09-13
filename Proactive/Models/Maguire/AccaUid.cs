using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccaUid
    {
        public Guid AccaUidId { get; set; }

        public virtual Activity AccaUidNavigation { get; set; }
    }
}
