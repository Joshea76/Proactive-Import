using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationDefinition
    {
        public Guid IdefId { get; set; }
        public byte[] Definition { get; set; }
        public string Version { get; set; }
    }
}
