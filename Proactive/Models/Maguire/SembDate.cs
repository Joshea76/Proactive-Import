using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembDate
    {
        public Guid SembDateId { get; set; }

        public virtual SeminarsBooking SembDateNavigation { get; set; }
    }
}
