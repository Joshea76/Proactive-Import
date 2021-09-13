using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Event
    {
        public Guid? AcId { get; set; }
        public Guid RefId { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string ParentSummary { get; set; }
        public Guid? ParentId { get; set; }
        public string ParentType { get; set; }
        public string Class { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid EvId { get; set; }
        public Guid? ActId { get; set; }
        public Guid? PjId { get; set; }
        public Guid? OpId { get; set; }
        public string Details { get; set; }
        public Guid? SemId { get; set; }
        public Guid? McaId { get; set; }
        public Guid? SrcId { get; set; }

        public virtual Account Ac { get; set; }
    }
}
