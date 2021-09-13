using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembaDate
    {
        public Guid SembaDateId { get; set; }

        public virtual SeminarsBookingsAttendee SembaDateNavigation { get; set; }
    }
}
