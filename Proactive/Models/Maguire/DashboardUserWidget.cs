using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DashboardUserWidget
    {
        public DashboardUserWidget()
        {
            DashboardUserWidgetLabels = new HashSet<DashboardUserWidgetLabel>();
        }

        public int DuwId { get; set; }
        public Guid UsrId { get; set; }
        public int? DshId { get; set; }
        public int DshOrder { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int? DhoId { get; set; }
        public string DhoFilters { get; set; }
        public string DhoFiltertext { get; set; }
        public string DhoSummary { get; set; }
        public Guid? LocationRef { get; set; }
        public Guid? ReqId { get; set; }
        public Guid? SublistSectionId { get; set; }
        public Guid? WidgetSectionId { get; set; }
        public Guid? OverviewSectionId { get; set; }
        public Guid? StagingDspsId { get; set; }
        public Guid? StagingDscId { get; set; }
        public byte? WidgetType { get; set; }

        public virtual ICollection<DashboardUserWidgetLabel> DashboardUserWidgetLabels { get; set; }
    }
}
