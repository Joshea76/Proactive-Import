using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Request
    {
        public Request()
        {
            RequestsDisplayIds = new HashSet<RequestsDisplayId>();
            WidgetsOnDashboards = new HashSet<WidgetsOnDashboard>();
        }

        public Guid ReqId { get; set; }
        public byte RequestType { get; set; }
        public string RequestData { get; set; }
        public Guid? DesignId { get; set; }

        public virtual ICollection<RequestsDisplayId> RequestsDisplayIds { get; set; }
        public virtual ICollection<WidgetsOnDashboard> WidgetsOnDashboards { get; set; }
    }
}
