using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Component
    {
        public Guid ComId { get; set; }
        public Guid AreaId { get; set; }
        public string Summary { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public bool RequiresDeleting { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
        public short Order { get; set; }
        public Guid? PageId { get; set; }

        public virtual Area Area { get; set; }
    }
}
