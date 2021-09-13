using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SemDate
    {
        public Guid SemDateId { get; set; }

        public virtual Seminar SemDateNavigation { get; set; }
    }
}
