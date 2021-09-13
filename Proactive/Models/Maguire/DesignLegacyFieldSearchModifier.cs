using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFieldSearchModifier
    {
        public Guid SmId { get; set; }
        public short SearchModifier { get; set; }
        public Guid LfdId { get; set; }

        public virtual DesignLegacyField Lfd { get; set; }
    }
}
