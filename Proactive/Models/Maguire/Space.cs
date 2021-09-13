using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Space
    {
        public Space()
        {
            ComponentVersions = new HashSet<ComponentVersion>();
            Groups = new HashSet<Group>();
            PortalVersion1s = new HashSet<PortalVersion1>();
            RoleGroups = new HashSet<RoleGroup>();
            SpaceRoles = new HashSet<SpaceRole>();
            SpaceVersions = new HashSet<SpaceVersion>();
            ThemeVersions = new HashSet<ThemeVersion>();
            Themes = new HashSet<Theme>();
        }

        public Guid SpaceId { get; set; }
        public Guid SiId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Published { get; set; }
        public Guid CreatedByUsId { get; set; }
        public Guid LastUpdatedByUsId { get; set; }
        public int? CurrentVersionNumber { get; set; }
        public int? LastPublishedVersionId { get; set; }
        public bool IsAvailable { get; set; }
        public string Url { get; set; }
        public bool? IsAuth { get; set; }
        public bool? InitialPublishComplete { get; set; }

        public virtual User CreatedByUs { get; set; }
        public virtual Integration Si { get; set; }
        public virtual ICollection<ComponentVersion> ComponentVersions { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<PortalVersion1> PortalVersion1s { get; set; }
        public virtual ICollection<RoleGroup> RoleGroups { get; set; }
        public virtual ICollection<SpaceRole> SpaceRoles { get; set; }
        public virtual ICollection<SpaceVersion> SpaceVersions { get; set; }
        public virtual ICollection<ThemeVersion> ThemeVersions { get; set; }
        public virtual ICollection<Theme> Themes { get; set; }
    }
}
