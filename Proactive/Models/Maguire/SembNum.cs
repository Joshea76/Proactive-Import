using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembNum
    {
        public Guid SembNumId { get; set; }

        public virtual SeminarsBooking SembNumNavigation { get; set; }
    }
}
