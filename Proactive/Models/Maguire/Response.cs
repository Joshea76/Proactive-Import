using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Response
    {
        public Guid RspId { get; set; }
        public string ResponseType { get; set; }
        public string ResponseData { get; set; }
    }
}
