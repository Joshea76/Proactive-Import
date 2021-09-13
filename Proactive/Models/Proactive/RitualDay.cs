using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class RitualDay
    {
        public int RitualDayId { get; set; }
        public int DayId { get; set; }
        public int RitualId { get; set; }
        public int TimePeriodId { get; set; }
        public string UserId { get; set; }

        public virtual Day Day { get; set; }
        public virtual Ritual Ritual { get; set; }
        public virtual TimePeriod TimePeriod { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
