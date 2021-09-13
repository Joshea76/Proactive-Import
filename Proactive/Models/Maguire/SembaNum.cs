using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembaNum
    {
        public Guid SembaNumId { get; set; }

        public virtual SeminarsBookingsAttendee SembaNumNavigation { get; set; }
    }
}
