using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TagsLink
    {
        public int TaglId { get; set; }
        public int? TagId { get; set; }
        public Guid? ObjId { get; set; }
        public bool Propagated { get; set; }
        public Guid? PropagatedId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
