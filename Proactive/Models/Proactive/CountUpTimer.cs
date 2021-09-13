using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class CountUpTimer
    {
        public int CountUpTimerId { get; set; }
        public string UserId { get; set; }
        public DateTime Started { get; set; }
        public string PageReference { get; set; }
        public string TimerReference { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
