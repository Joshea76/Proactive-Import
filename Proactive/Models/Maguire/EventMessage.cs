using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class EventMessage
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public Guid? TaskId { get; set; }
        public string JobType { get; set; }
        public string TaskType { get; set; }
        public int? DurationSeconds { get; set; }
        public DateTime? RaisedDate { get; set; }
        public int? MessageStatus { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Guid SourceId { get; set; }
        public bool? Skipped { get; set; }
    }
}
