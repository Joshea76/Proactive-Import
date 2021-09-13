using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignLegacyFieldAssociation
    {
        public int Id { get; set; }
        public Guid DesignLegacyFieldId { get; set; }
        public short AssociationType { get; set; }
        public Guid AssociatedDesignLegacyFieldId { get; set; }

        public virtual DesignLegacyField AssociatedDesignLegacyField { get; set; }
        public virtual DesignLegacyField DesignLegacyField { get; set; }
    }
}
