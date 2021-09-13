using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembaUid
    {
        public Guid SembaUidId { get; set; }

        public virtual SeminarsBookingsAttendee SembaUidNavigation { get; set; }
    }
}
