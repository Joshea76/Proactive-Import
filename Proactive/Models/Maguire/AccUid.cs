using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccUid
    {
        public Guid AccUidId { get; set; }

        public virtual AccountsContact AccUidNavigation { get; set; }
    }
}
