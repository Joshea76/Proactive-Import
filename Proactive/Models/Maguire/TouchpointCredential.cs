using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointCredential
    {
        public Guid TpiId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
