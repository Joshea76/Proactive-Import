using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AcNum
    {
        public Guid AcNumId { get; set; }

        public virtual Account AcNumNavigation { get; set; }
    }
}
