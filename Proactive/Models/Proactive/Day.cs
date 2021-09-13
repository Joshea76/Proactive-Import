using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Day
    {
        public Day()
        {
            RitualDays = new HashSet<RitualDay>();
        }

        public int DayId { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<RitualDay> RitualDays { get; set; }
    }
}
