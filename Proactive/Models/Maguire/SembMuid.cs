using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembMuid
    {
        public Guid SembMuidId { get; set; }

        public virtual SeminarsBooking SembMuidNavigation { get; set; }
    }
}
