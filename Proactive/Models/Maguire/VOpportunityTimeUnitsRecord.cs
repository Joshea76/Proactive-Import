using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VOpportunityTimeUnitsRecord
    {
        public Guid TurId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Guid UsId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Guid? AcId { get; set; }
        public Guid? OpId { get; set; }
        public Guid? OpaId { get; set; }
        public int TimeUnitValue { get; set; }
        public DateTime? DateRecorded { get; set; }
        public Guid? OpqdId { get; set; }
        public string AccountSummary { get; set; }
        public Guid? ParentId { get; set; }
        public string ParentItem { get; set; }
        public string RecordUserSummary { get; set; }
        public bool? TimeUnitIsTime { get; set; }
        public string ParentSummary { get; set; }
        public string QuoteDetailSummary { get; set; }
        public Guid AcoId { get; set; }
        public Guid UsgId { get; set; }
        public string UserTeamName { get; set; }
        public string ShortCode { get; set; }
    }
}
