using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class RequestsDisplayId
    {
        public int DisplayId { get; set; }
        public Guid ReqId { get; set; }

        public virtual Request Req { get; set; }
    }
}
