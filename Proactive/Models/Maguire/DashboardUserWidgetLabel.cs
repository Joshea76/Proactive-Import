using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DashboardUserWidgetLabel
    {
        public int DuwId { get; set; }
        public Guid LangId { get; set; }
        public Guid LabelId { get; set; }
        public string Label { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual DashboardUserWidget Duw { get; set; }
        public virtual Language Lang { get; set; }
    }
}
