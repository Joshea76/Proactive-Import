using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Role
    {
        public Role()
        {
            AreaRoles = new HashSet<AreaRole>();
            ComponentRoles = new HashSet<ComponentRole>();
            PageRoles = new HashSet<PageRole>();
            RoleGroups = new HashSet<RoleGroup>();
            SpaceRoles = new HashSet<SpaceRole>();
        }

        public Guid RId { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public Guid? TemplateId { get; set; }
        public bool? Mandatory { get; set; }
        public string DisplayName { get; set; }

        public virtual Template Template { get; set; }
        public virtual ICollection<AreaRole> AreaRoles { get; set; }
        public virtual ICollection<ComponentRole> ComponentRoles { get; set; }
        public virtual ICollection<PageRole> PageRoles { get; set; }
        public virtual ICollection<RoleGroup> RoleGroups { get; set; }
        public virtual ICollection<SpaceRole> SpaceRoles { get; set; }
    }
}
