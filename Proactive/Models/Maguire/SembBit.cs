using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembBit
    {
        public Guid SembBitId { get; set; }

        public virtual SeminarsBooking SembBitNavigation { get; set; }
    }
}
