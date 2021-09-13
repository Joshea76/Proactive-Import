using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class RequiredVersion
    {
        public Guid IntegrationId { get; set; }
        public string RequiredVersion1 { get; set; }
        public string Item { get; set; }
    }
}
