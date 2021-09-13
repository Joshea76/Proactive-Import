using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class RoleGroupCollectionsRole
    {
        public Guid RgcId { get; set; }
        public Guid RId { get; set; }

        public virtual Role RIdNavigation { get; set; }
        public virtual RoleGroupCollection Rgc { get; set; }
    }
}
