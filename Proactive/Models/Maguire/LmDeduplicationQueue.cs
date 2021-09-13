using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmDeduplicationQueue
    {
        public LmDeduplicationQueue()
        {
            LmDeduplicationItems = new HashSet<LmDeduplicationItem>();
            LmDuplicateEntities = new HashSet<LmDuplicateEntity>();
        }

        public int DdId { get; set; }
        public int? CsId { get; set; }
        public int? LcId { get; set; }
        public string PackageName { get; set; }
        public bool? BulkDeduplication { get; set; }
        public DateTime? ScheduledStart { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? CompletedTime { get; set; }
        public byte? DdStatus { get; set; }
        public int? ErrorCount { get; set; }
        public string FailedMessage { get; set; }
        public bool RecalcOnly { get; set; }
        public int? LastRuleId { get; set; }
        public Guid? LastBatchId { get; set; }

        public virtual LmContactSpine Cs { get; set; }
        public virtual ICollection<LmDeduplicationItem> LmDeduplicationItems { get; set; }
        public virtual ICollection<LmDuplicateEntity> LmDuplicateEntities { get; set; }
    }
}
