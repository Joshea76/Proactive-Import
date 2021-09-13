using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Target
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
    }
}
