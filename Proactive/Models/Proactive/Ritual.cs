using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Ritual
    {
        public Ritual()
        {
            RitualDays = new HashSet<RitualDay>();
        }

        public int RitualId { get; set; }
        public string RitualName { get; set; }
        public string RitualDesc { get; set; }
        public int DisplayRitual { get; set; }
        public string UserId { get; set; }
        public string TimePeriods { get; set; }
        public string RitualDayIds { get; set; }
        public int? TargetNumber { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<RitualDay> RitualDays { get; set; }
    }
}
