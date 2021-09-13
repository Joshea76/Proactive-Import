using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ServicesSchedule
    {
        public Guid ServiceScheduleItemId { get; set; }
        public string Name { get; set; }
        public string ProjectName { get; set; }
        public string StartMethodName { get; set; }
        public string StopMethodName { get; set; }
        public int MethodRunType { get; set; }
        public int? MethodIntervalSeconds { get; set; }
        public DateTime? StartMethodLastRun { get; set; }
        public DateTime? StopMethodLastRun { get; set; }
        public bool MethodStopped { get; set; }
        public bool? CallMethodStop { get; set; }
        public byte? ServiceStatus { get; set; }
    }
}
