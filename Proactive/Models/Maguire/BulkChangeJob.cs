using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class BulkChangeJob
    {
        public Guid BlcId { get; set; }
        public string Summary { get; set; }
        public DateTime Created { get; set; }
        public byte Status { get; set; }
        public byte JobType { get; set; }
        public int Processed { get; set; }
        public int Total { get; set; }
        public Guid? TargetFieldId { get; set; }
        public string Value { get; set; }
        public Guid ReqId { get; set; }
        public Guid? UserId { get; set; }
        public string TagIds { get; set; }
        public bool? TagAction { get; set; }
        public string DatabaseColumnName { get; set; }
        public byte? Modifier { get; set; }
    }
}
