using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TimePeriod
    {
        public TimePeriod()
        {
            RitualDays = new HashSet<RitualDay>();
        }

        public int TimePeriodId { get; set; }
        public string PeriodName { get; set; }

        public virtual ICollection<RitualDay> RitualDays { get; set; }
    }
}
