using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class MarketingControlJob
    {
        public int JobId { get; set; }
        public byte JobType { get; set; }
        public byte JobState { get; set; }
        public Guid? SourceId { get; set; }
        public Guid? StageId { get; set; }
        public bool? RefreshParents { get; set; }
        public bool? RefreshSources { get; set; }
        public bool? BlockActivities { get; set; }
        public bool? NewRecipientsOnly { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime? UpdatedDateUtc { get; set; }
        public DateTime? ProcessStartUtc { get; set; }
        public DateTime? ProcessEndUtc { get; set; }
        public Guid UserId { get; set; }
        public Guid? RunId { get; set; }
        public string TemplatePath { get; set; }
    }
}
