using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Group
    {
        public Group()
        {
            RoleGroups = new HashSet<RoleGroup>();
        }

        public Guid GId { get; set; }
        public string Description { get; set; }
        public int? Priority { get; set; }
        public Guid SpaceId { get; set; }

        public virtual Space Space { get; set; }
        public virtual ICollection<RoleGroup> RoleGroups { get; set; }
    }
}
