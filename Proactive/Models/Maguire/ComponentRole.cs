using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ComponentRole
    {
        public Guid CrId { get; set; }
        public Guid ComId { get; set; }
        public Guid RId { get; set; }

        public virtual Role RIdNavigation { get; set; }
    }
}
