using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcaDate
    {
        public Guid AcaDateId { get; set; }

        public virtual Activity AcaDateNavigation { get; set; }
    }
}
