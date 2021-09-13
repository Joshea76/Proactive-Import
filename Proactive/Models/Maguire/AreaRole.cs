using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AreaRole
    {
        public Guid SrId { get; set; }
        public Guid AreaId { get; set; }
        public Guid RId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Role RIdNavigation { get; set; }
    }
}
