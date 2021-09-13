using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VProductTargetDef
    {
        public Guid TardId { get; set; }
        public string TargetType { get; set; }
        public string Summary { get; set; }
        public decimal? DefaultValue { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string OwnerType { get; set; }
    }
}
