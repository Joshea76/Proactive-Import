using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DashboardHomepageLabel
    {
        public int DhoId { get; set; }
        public Guid LangId { get; set; }
        public Guid LabelId { get; set; }
        public string Label { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual DashboardHomepage Dho { get; set; }
        public virtual Language Lang { get; set; }
    }
}
