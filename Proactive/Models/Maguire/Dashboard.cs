using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Dashboard
    {
        public Dashboard()
        {
            WidgetsOnDashboards = new HashSet<WidgetsOnDashboard>();
        }

        public Guid DshId { get; set; }
        public string Summary { get; set; }
        public Guid UsId { get; set; }
        public Guid? LocationReference { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public int DisplayOrder { get; set; }

        public virtual User Us { get; set; }
        public virtual ICollection<WidgetsOnDashboard> WidgetsOnDashboards { get; set; }
    }
}
