using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Widget
    {
        public Widget()
        {
            WidgetsOnDashboards = new HashSet<WidgetsOnDashboard>();
        }

        public Guid WidId { get; set; }
        public string Summary { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public Guid? XAxisFieldId { get; set; }
        public Guid? YAxisFieldId { get; set; }
        public Guid? SeriesFieldId { get; set; }
        public short WidgetType { get; set; }
        public short ChartType { get; set; }

        public virtual ICollection<WidgetsOnDashboard> WidgetsOnDashboards { get; set; }
    }
}
