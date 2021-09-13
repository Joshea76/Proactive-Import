using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class WidgetsOnDashboard
    {
        public Guid DshId { get; set; }
        public Guid WidId { get; set; }
        public int DisplayWidth { get; set; }
        public int DisplayHeight { get; set; }
        public int DisplayOrder { get; set; }
        public Guid? ReqId { get; set; }

        public virtual Dashboard Dsh { get; set; }
        public virtual Request Req { get; set; }
        public virtual Widget Wid { get; set; }
    }
}
