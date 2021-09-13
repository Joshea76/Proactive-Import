using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFieldDefault
    {
        public Guid LfdId { get; set; }
        public string DefaultValue { get; set; }
        public string DefaultDisplayValue { get; set; }
    }
}
