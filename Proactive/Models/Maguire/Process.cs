using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Process
    {
        public int ProcessId { get; set; }
        public string StoredProcedureName { get; set; }
        public int ExecutionFrequencyMinutes { get; set; }
        public TimeSpan ExecutionBetweenStartTime { get; set; }
        public TimeSpan ExecutionBetweenEndTime { get; set; }
        public DateTime LastRunUtcDateTime { get; set; }
    }
}
