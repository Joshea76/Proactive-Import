using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Module
    {
        public Module()
        {
            Areas = new HashSet<Area>();
            Pages = new HashSet<Page>();
        }

        public Guid ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleAlias { get; set; }
        public int AreaType { get; set; }
        public int Category { get; set; }
        public bool Enabled { get; set; }
        public bool RequiresSubscription { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
    }
}
