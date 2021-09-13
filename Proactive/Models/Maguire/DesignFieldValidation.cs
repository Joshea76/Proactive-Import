using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignFieldValidation
    {
        public Guid DfvId { get; set; }
        public Guid LfdId { get; set; }
        public int? Type { get; set; }
        public string Regex { get; set; }
        public Guid? CustomMessageId { get; set; }

        public virtual DesignLegacyField Lfd { get; set; }
    }
}
