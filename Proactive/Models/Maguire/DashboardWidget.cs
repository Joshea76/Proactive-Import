using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DashboardWidget
    {
        public DashboardWidget()
        {
            DashboardWidgetLabels = new HashSet<DashboardWidgetLabel>();
        }

        public int DshId { get; set; }
        public string Def { get; set; }
        public string Summary { get; set; }
        public string SummaryRef { get; set; }
        public string Type { get; set; }
        public string ListType { get; set; }
        public Guid? UsrId { get; set; }
        public bool? IsPublic { get; set; }
        public DateTime? Deleted { get; set; }
        public Guid? DesignId { get; set; }
        public bool IsItemDesignTheme { get; set; }
        public byte WidthType { get; set; }
        public string YAxisLabelGroupType { get; set; }
        public string YAxisTimeUnitDataType { get; set; }

        public virtual ICollection<DashboardWidgetLabel> DashboardWidgetLabels { get; set; }
    }
}
