using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembUid
    {
        public Guid SembUidId { get; set; }

        public virtual SeminarsBooking SembUidNavigation { get; set; }
    }
}
