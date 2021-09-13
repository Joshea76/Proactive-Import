using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SembTxt
    {
        public Guid SembTxtId { get; set; }

        public virtual SeminarsBooking SembTxtNavigation { get; set; }
    }
}
