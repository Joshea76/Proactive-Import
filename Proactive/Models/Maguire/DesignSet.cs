using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignSet
    {
        public DesignSet()
        {
            DesignEntities = new HashSet<DesignEntity>();
            DesignLists = new HashSet<DesignList>();
            DesignScreens = new HashSet<DesignScreen>();
            DesignThemes = new HashSet<DesignTheme>();
        }

        public Guid DstId { get; set; }

        public virtual ICollection<DesignEntity> DesignEntities { get; set; }
        public virtual ICollection<DesignList> DesignLists { get; set; }
        public virtual ICollection<DesignScreen> DesignScreens { get; set; }
        public virtual ICollection<DesignTheme> DesignThemes { get; set; }
    }
}
