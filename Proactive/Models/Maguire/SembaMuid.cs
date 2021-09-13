using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembaMuid
    {
        public Guid SembaMuidId { get; set; }

        public virtual SeminarsBookingsAttendee SembaMuidNavigation { get; set; }
    }
}
