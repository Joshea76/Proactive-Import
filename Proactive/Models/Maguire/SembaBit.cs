using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembaBit
    {
        public Guid SembaBitId { get; set; }

        public virtual SeminarsBookingsAttendee SembaBitNavigation { get; set; }
    }
}
