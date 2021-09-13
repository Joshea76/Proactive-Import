using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFieldMixedListLink
    {
        public Guid ScreenLfdId { get; set; }
        public Guid ListLfdId { get; set; }

        public virtual DesignLegacyField ListLfd { get; set; }
        public virtual DesignLegacyField ScreenLfd { get; set; }
    }
}
