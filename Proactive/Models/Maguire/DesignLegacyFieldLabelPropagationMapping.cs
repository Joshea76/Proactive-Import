using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFieldLabelPropagationMapping
    {
        public Guid FromLfdId { get; set; }
        public Guid ToLfdId { get; set; }

        public virtual DesignLegacyField FromLfd { get; set; }
        public virtual DesignLegacyField ToLfd { get; set; }
    }
}
