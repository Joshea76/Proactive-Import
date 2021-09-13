using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SemNum
    {
        public Guid SemNumId { get; set; }

        public virtual Seminar SemNumNavigation { get; set; }
    }
}
