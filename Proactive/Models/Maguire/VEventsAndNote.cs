using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VEventsAndNote
    {
        public Guid EvId { get; set; }
        public Guid RefId { get; set; }
        public Guid? AcId { get; set; }
        public Guid? ActId { get; set; }
        public Guid? PjId { get; set; }
        public Guid? OpId { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public string Type { get; set; }
        public string ParentSummary { get; set; }
        public Guid? ParentId { get; set; }
        public string ParentType { get; set; }
        public string Class { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string AcdPath { get; set; }
        public string Path { get; set; }
        public string AcName { get; set; }
        public string AcoSummary { get; set; }
        public string AcoSingularLabel { get; set; }
        public string AcoPluralLabel { get; set; }
        public Guid AcoId { get; set; }
        public string AcGroup { get; set; }
        public Guid? UsIdSales { get; set; }
        public string AccountManager { get; set; }
        public string AcType1 { get; set; }
        public string AcType2 { get; set; }
        public string AcType1Hlight { get; set; }
        public string AcType2Hlight { get; set; }
        public string EventDetails { get; set; }
    }
}
