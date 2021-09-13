using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class CustomItemRequest
    {
        public Guid ReqId { get; set; }
        public byte RequestType { get; set; }
        public string RequestData { get; set; }
    }
}
