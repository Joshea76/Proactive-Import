using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DashboardHomepage
    {
        public DashboardHomepage()
        {
            DashboardHomepageLabels = new HashSet<DashboardHomepageLabel>();
        }

        public int DhoId { get; set; }
        public Guid UsId { get; set; }
        public int? DhoOrder { get; set; }
        public string Summary { get; set; }
        public bool Selected { get; set; }
        public DateTime? Deleted { get; set; }
        public bool CopyAllowed { get; set; }

        public virtual ICollection<DashboardHomepageLabel> DashboardHomepageLabels { get; set; }
    }
}
