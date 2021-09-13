using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembaTxt
    {
        public Guid SembaTxtId { get; set; }

        public virtual SeminarsBookingsAttendee SembaTxtNavigation { get; set; }
    }
}
