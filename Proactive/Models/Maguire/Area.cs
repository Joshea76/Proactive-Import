using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Area
    {
        public Area()
        {
            AdditionalFieldsConfigurations = new HashSet<AdditionalFieldsConfiguration>();
            AreaRoles = new HashSet<AreaRole>();
            Components = new HashSet<Component>();
            Pages = new HashSet<Page>();
        }

        public Guid AreaId { get; set; }
        public Guid SpaceId { get; set; }
        public string AreaName { get; set; }
        public bool Created { get; set; }
        public int? Type { get; set; }
        public bool IsHidden { get; set; }
        public bool RequiresDeleting { get; set; }
        public bool Deleted { get; set; }
        public DateTime? LastSaved { get; set; }
        public bool RedirectFromParent { get; set; }
        public string MenuTitle { get; set; }
        public bool? IsMenuPage { get; set; }
        public bool? ShowMenu { get; set; }
        public int Order { get; set; }
        public Guid? ModuleId { get; set; }

        public virtual Module Module { get; set; }
        public virtual ICollection<AdditionalFieldsConfiguration> AdditionalFieldsConfigurations { get; set; }
        public virtual ICollection<AreaRole> AreaRoles { get; set; }
        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
    }
}
