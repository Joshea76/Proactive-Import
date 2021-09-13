using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class RoleGroup
    {
        public Guid RgId { get; set; }
        public Guid RId { get; set; }
        public Guid GId { get; set; }
        public Guid SpaceId { get; set; }

        public virtual Group GIdNavigation { get; set; }
        public virtual Role RIdNavigation { get; set; }
        public virtual Space Space { get; set; }
    }
}
