using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VAlertTrace
    {
        public Guid AeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ObjectType { get; set; }
        public Guid? ObjId { get; set; }
        public string ObjectSummary { get; set; }
        public Guid? AlId { get; set; }
        public string AlertTitle { get; set; }
        public string AlertDescription { get; set; }
        public byte? State { get; set; }
        public string AlertType { get; set; }
        public string Status { get; set; }
    }
}
