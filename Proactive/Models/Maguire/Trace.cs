using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Trace
    {
        public long Id { get; set; }
        public string InstanceName { get; set; }
        public Guid ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int EventId { get; set; }
        public long EventKeywords { get; set; }
        public int Level { get; set; }
        public int Opcode { get; set; }
        public int Task { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public int Version { get; set; }
        public string FormattedMessage { get; set; }
        public string Payload { get; set; }
        public Guid? ActivityId { get; set; }
        public Guid? RelatedActivityId { get; set; }
        public int? ProcessId { get; set; }
        public int? ThreadId { get; set; }
    }
}
