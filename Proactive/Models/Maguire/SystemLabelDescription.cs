using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SystemLabelDescription
    {
        public SystemLabelDescription()
        {
            SystemLabels = new HashSet<SystemLabel>();
        }

        public Guid LabelId { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SystemLabel> SystemLabels { get; set; }
    }
}
