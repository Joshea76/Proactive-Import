using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class PrivacyRulesOption
    {
        public Guid PrroId { get; set; }
        public Guid PrroPrrId { get; set; }
        public Guid? PrroOptionId { get; set; }

        public virtual PrivacyRule PrroPrr { get; set; }
    }
}
