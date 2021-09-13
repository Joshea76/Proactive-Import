using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class WorkRecord
    {
        public int WorkRecordId { get; set; }
        public int WorkTimeTaken { get; set; }
        public DateTime DateDone { get; set; }
        public int? RitualId { get; set; }
        public string UserId { get; set; }
        public int Done { get; set; }
        public int TargetNumber { get; set; }
        public string Timer { get; set; }
        public string Note { get; set; }
        public double? WorkMinutesPerDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
