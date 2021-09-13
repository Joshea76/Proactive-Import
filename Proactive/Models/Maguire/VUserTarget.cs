using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VUserTarget
    {
        public Guid TarId { get; set; }
        public Guid TardId { get; set; }
        public Guid? OwnerId { get; set; }
        public decimal TargetValue { get; set; }
        public DateTime? StartDate { get; set; }
        public string Summary { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public Guid? CurId { get; set; }
        public string TarName { get; set; }
        public string OwnerName { get; set; }
        public string TardName { get; set; }
        public string CurSymbol { get; set; }
    }
}
