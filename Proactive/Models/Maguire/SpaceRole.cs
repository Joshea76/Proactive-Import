using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SpaceRole
    {
        public Guid SrId { get; set; }
        public Guid SpaceId { get; set; }
        public Guid RId { get; set; }

        public virtual Role RIdNavigation { get; set; }
        public virtual Space Space { get; set; }
    }
}
