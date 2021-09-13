using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UvIntegrationId
    {
        public string Summary { get; set; }
        public string IntegrationName { get; set; }
        public string IntegrationType { get; set; }
        public string IntegrationId { get; set; }
        public Guid? FneId { get; set; }
    }
}
