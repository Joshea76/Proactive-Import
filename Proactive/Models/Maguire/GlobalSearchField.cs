using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GlobalSearchField
    {
        public Guid ScreenDesignId { get; set; }
        public Guid LegacyFieldId { get; set; }

        public virtual DesignLegacyField LegacyField { get; set; }
        public virtual DesignScreen ScreenDesign { get; set; }
    }
}
