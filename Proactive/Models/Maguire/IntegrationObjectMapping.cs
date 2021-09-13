using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class IntegrationObjectMapping
    {
        public Guid IomId { get; set; }
        public string GvObjectName { get; set; }
        public string IntegrationObjectName { get; set; }
    }
}
